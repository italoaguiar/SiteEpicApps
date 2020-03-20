using System.Web;
using System.Web.Optimization;

namespace EpicApps
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery.js",
                        "~/Content/js/jquery.mixitup.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.js",
                      "~/Content/js/modernizr.custom.js",
                      "~/Content/js/jquery.bxslider.js",
                      "~/Content/js/jquery.cslider.js",
                      "~/Content/js/jquery.placeholder.js",
                      "~/Content/js/jquery.inview.js",
                      "~/Content/js/respond.min.js",
                      "~/Content/js/app.js"));

            bundles.Add(new StyleBundle("~/styles/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/bootstrap-responsive.css",
                      "~/Content/css/jquery.bxslider.css",
                      "~/Content/css/jquery.cslider.css",
                      "~/Content/css/animate.css"));
            bundles.Add(new StyleBundle("~/styles/css/theme").Include(
                      "~/Content/css/style.css",
                      "~/Content/css/pluton.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
