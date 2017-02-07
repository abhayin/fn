using System.Web;
using System.Web.Optimization;

namespace User
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
                        "~/Scripts/Theme/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                      "~/Scripts/Theme/jquery.min.js",
                      "~/Scripts/Theme/jquery.appear.min.js",
                      "~/Scripts/Theme/jquery.easing.min.js",
                      "~/Scripts/Theme/bootstrap.min.js",
                      "~/Scripts/Theme/common.min.js",
                      "~/Scripts/Theme/jquery.validation.min.js",
                      "~/Scripts/Theme/jquery.stellar.min.js",
                      "~/Scripts/Theme/jquery.gmap.min.js",
                      "~/Scripts/Theme/jquery.lazyload.min.js",
                      "~/Scripts/Theme/jquery.isotope.min.js",
                      "~/Scripts/Theme/owl.carousel.min.js",
                      "~/Scripts/Theme/jquery.magnific-popup.min.js",
                      "~/Scripts/Theme/vide.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/simple-line-icons.min.css",
                      "~/Content/css/assets/owl.carousel.min.css",
                      "~/Content/css/owl.theme.default.min.css",
                      "~/Content/css/magnific-popup.min.css",
                      "~/Content/css/theme.css",
                      "~/Content/css/theme-elements.css",
                      "~/Content/css/theme-blog.css",
                      "~/Content/css/theme-shop.css",
                      "~/Content/css/default.css",
                      "~/Content/css/custom.css"));
           }
    }
}