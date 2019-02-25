using BOL.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SINACO_ERP.Areas.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SINACO_ERP.Areas.Security.Controllers
{
    /// <summary>
    /// Credted By : M.Abdullah Sheikh    2/18/2019
    /// Modified By: M.Abdullah Sheikh    2/19/2019
    /// Description:
    /// </summary>
    public class AccountController : Controller
    {

        public UserManager<MyUser, int> UserManager { get; private set; }

        public AccountController() : this(new UserManager<MyUser, int>(new UserStore<MyUser, MyRole, int, MyLogin, MyUserRole, MyClaim>(new ApplicationDbContext())))
        {
        }

        public AccountController(UserManager<MyUser, int> userManager)
        {
            try
            {
                UserManager = userManager;
            }
            catch (Exception ex)
            {

            }
        }

        public ActionResult Register()
        {
            return View();
        }

        public JsonResult ValidateUserName()
        {
            using (SinacoERPEntities db = new SinacoERPEntities())
            {
                int id = 0;
                if (Request.QueryString["Id"] != null)
                {
                    int.TryParse(Request.QueryString["Id"], out id);
                }
                var filedID = Request["fieldId"];
                var username = Request["fieldValue"];
                string[] arrayToJs = new string[3];
                arrayToJs[0] = filedID;
                if (id > 0)
                {
                    if (db.AspNetUsers.Count(c => c.UserName == username && c.Id != id) > 0)
                    {
                        arrayToJs[1] = "false";
                        arrayToJs[2] = "Username already exist";
                    }
                    else
                    {
                        arrayToJs[1] = "true";
                        arrayToJs[2] = "Valid Username";
                    }
                }
                else
                {
                    if (db.AspNetUsers.Count(c => c.UserName == username) > 0)
                    {
                        arrayToJs[1] = "false";
                        arrayToJs[2] = "Username already exist";
                    }
                    else
                    {
                        arrayToJs[1] = "true";
                        arrayToJs[2] = "Valid Username";
                    }
                }

                return Json(arrayToJs, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            try
            {
                //if (SecCommon.CanAccessPrivilege(SecCommon.Privilege.Can_Add_User, int.Parse((User.Identity.GetUserId()))))
                // {
                int CompanyID = 1;
                if (ModelState.IsValid)
                {

                    var user = new MyUser() { UserName = model.UserName, EmailConfirmed = false, LockoutEnabled = true , PhoneNumberConfirmed = false, TwoFactorEnabled = true, LockoutEndDateUtc = DateTime.Now,  IsActive = model.IsActive, PageSize = model.PageSize, CompanyId = CompanyID, EmployeeId = model.EmployeeId };
                    var result = await UserManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        //SEC_UserRole objUserRole = new SEC_UserRole();
                        //objUserRole.UserId = user.Id;
                        //objUserRole.RoleId = model.role;
                        //db.SEC_UserRole.Add(objUserRole);
                        //await db.SaveChangesAsync();

                        await SignInAsync(user, isPersistent: false);
                        return Redirect("/Dashboard/Home/Index");
                    }
                    else
                    {

                        AddErrors(result);
                    }
                }
                //ViewBag.PayMethodIDFK = new SelectList(db.bos_PayMethod.Where(x => x.IsActive == true && x.CompanyIDFk == CompanyID).OrderBy(a => a.Title).ToList(), "id", "Title");
                //ViewBag.role = new SelectList(db.SEC_ROLES.Where(x => x.isActive == true && x.CompanyIDFK == CompanyID).OrderBy(a => a.RoleName).ToList(),
                //  "RoleID", "RoleName");
                // If we got this far, something failed, redisplay form
                return View(model);
                // }
                // else
                //return RedirectToAction("Index");

            }

            catch (Exception ex)
            {
                return Redirect("/Error/Error/");
            }
        }

        private void AddErrors(IdentityResult result)
        {
            try
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }
            catch (Exception ex)
            {
              
            }
        }


        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            try
            {
                ViewBag.ReturnUrl = returnUrl;
                return View();
            }
            catch (Exception ex)
            {
                return Redirect("/Error/Error/");
            }
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //int CompanyID = new Company_BLL().GetCompanyID(new ProducController().GetBaseUrl(Request));
                    //var check_active = (from n in db.AspNetUsers where n.IsActive == true && n.UserName == model.UserName && n.CompanyIDFK == CompanyID select n).Count();
                    //if (check_active > 0)
                    {
                        //db.SEC_RegisteredIPs.Where(x => x.RegisteredIP=='192.168.15.11') Azam

                        var user = await UserManager.FindAsync(model.UserName, model.Password);
                        if (user != null)
                        {
                            await SignInAsync(user, model.RememberMe);
                            if (returnUrl != null)
                                return RedirectToLocal(returnUrl);
                            else
                            {
                                bool isValidIP = true;// new DAL.Security.SecTaskHnd().isValidIP(user.Id, Request.ServerVariables["REMOTE_ADDR"].ToString());
                                if (isValidIP)
                                    return Redirect("/Dashboard/Home");
                                else
                                    return RedirectToLocal(returnUrl);

                            }

                        }
                        else
                        {
                            ModelState.AddModelError("", "Invalid username or password.");
                        }
                    }
                    //else
                    //{
                    //  ModelState.AddModelError("", "Invalid username or password.");
                    //}
                }

                // If we got this far, something failed, redisplay form
                return View(model);
            }
            catch (Exception ex)
            {
                return Redirect("/Error/Error/");
            }
        }

        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();
            return Redirect("/Security/Account/Login");
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            try
            {
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                //BLL_Common.InsertError(BLL_Common.getFilePath(ex.StackTrace.ToString()) + " " + string.Format("{0}{1}", ex.Message, (ex.InnerException != null) ? string.Concat(", inex: ", ex.InnerException.Message) : string.Empty), System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name.ToString(), new System.Diagnostics.StackFrame().GetMethod().Name.ToString());
                return Redirect("/Error/Error");
            }
        }
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        private async Task SignInAsync(MyUser user, bool isPersistent)
        {
            try
            {
                AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, identity);
            }
            catch (Exception ex)
            {
                //BLL_Common.InsertError(BLL_Common.getFilePath(ex.StackTrace.ToString()) + " " + string.Format("{0}{1}", ex.Message, (ex.InnerException != null) ? string.Concat(", inex: ", ex.InnerException.Message) : string.Empty), System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name.ToString(), new System.Diagnostics.StackFrame().GetMethod().Name.ToString());

            }
        }

        private class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties() { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
    }
}