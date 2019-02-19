using System.Web;
using System.Web.Optimization;

namespace MobileCan
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                      "~/Scripts/smoothproducts.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/shop-homepage.css",
                      "~/Content/smoothproducts.css"));

            bundles.Add(new StyleBundle("~/Admin/vendor/css").Include(
                "~/areas/admin/assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/areas/admin/assets/vendor/charts/chartist-bundle/chartist.css",
                "~/areas/admin/assets/vendor/charts/morris-bundle/morris.css",
                "~/areas/admin/assets/vendor/charts/c3charts/c3.css"
                ));

            bundles.Add(new StyleBundle("~/Areas/Admin/assets/libs/css/style").Include(
                "~/areas/admin/assets/libs/css/style.css"));

            bundles.Add(new ScriptBundle("~/Admin/vendor/js").Include(
                "~/areas/admin/assets/vendor/jquery/jquery-3.3.1.min.js",
                "~/areas/admin/assets/vendor/bootstrap/js/bootstrap.bundle.js",
                "~/areas/admin/assets/vendor/slimscroll/jquery.slimscroll.js",
                "~/areas/admin/assets/vendor/charts/chartist-bundle/chartist.min.js",
                "~/areas/admin/assets/vendor/charts/sparkline/jquery.sparkline.js",
                "~/areas/admin/assets/vendor/charts/morris-bundle/raphael.min.js",
                "~/areas/admin/assets/vendor/charts/morris-bundle/morris.js",
                "~/areas/admin/assets/vendor/charts/c3charts/c3.min.js",
                "~/areas/admin/assets/vendor/charts/c3charts/d3-5.4.0.min.js",
                "~/areas/admin/assets/vendor/charts/c3charts/C3chartjs.js"));

            bundles.Add(new ScriptBundle("~/Admin/libs/js").Include(
                "~/areas/admin/assets/libs/js/main-js.js",
                "~/areas/admin/assets/libs/js/dashboard-ecommerce.js"));


        }
    }
}
