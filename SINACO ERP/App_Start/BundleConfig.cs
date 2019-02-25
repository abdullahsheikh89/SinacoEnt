using System.Web;
using System.Web.Optimization;

namespace SINACO_ERP
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Stater Js Libararies
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/bower_components/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bower_components/bootstrap/dist/js/bootstrap.min.js",
                     "~/Scripts/dist/js/adminlte.min.js"));
            //Stater Css Libararies
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Scripts/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Scripts/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Scripts/dist/css/AdminLTE.min.css",
                      "~/Scripts/dist/css/skins/_all-skins.min.css"));

            //Jquery DataTables Css & Js Libraries
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include("" +
                "~/Scripts/bower_components/datatables.net/js/jquery.dataTables.min.js",
                "~/Scripts/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/Content/datatables").Include("~/Scripts/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css"));

            //Advance Elements Css & Js Libraries
            bundles.Add(new StyleBundle("~/Content/advanceelement").Include(
                "~/Scripts/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                "~/Scripts/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                "~/Scripts/bower_components/bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css",
                "~/Scripts/bower_components/select2/dist/css/select2.min.css",
                "~/Scripts/plugins/iCheck/all.css",
                "~/Scripts/plugins/timepicker/bootstrap-timepicker.min.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/advanceelement").Include(
                "~/Scripts/bower_components/moment/min/moment.min.js",
                "~/Scripts/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                "~/Scripts/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                "~/Scripts/bower_components/bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js",
                "~/Scripts/plugins/timepicker/bootstrap-timepicker.min.js",
                "~/Scripts/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/Scripts/bower_components/select2/dist/js/select2.full.min.js",
                "~/Scripts/plugins/input-mask/jquery.inputmask.js",
                "~/Scripts/plugins/input-mask/jquery.inputmask.date.extensions.js",
                "~/Scripts/plugins/input-mask/jquery.inputmask.extensions.js",
                "~/Scripts/plugins/iCheck/icheck.min.js",
                "~/Scripts/bower_components/fastclick/lib/fastclick.js"
                ));

            //Jquery Validation Engine Css & Js Libraries
            bundles.Add(new ScriptBundle("~/bundles/validation").Include(
               "~/Scripts/plugins/JqueyValidationEngine/jquery.validationEngine-en.js",
               "~/Scripts/plugins/JqueyValidationEngine/jquery.validationEngine.js"
               ));

            bundles.Add(new StyleBundle("~/Content/validation").Include(
                "~/Scripts/plugins/JqueyValidationEngine/validationEngine.jquery.css"
                ));


        }
    }
}
