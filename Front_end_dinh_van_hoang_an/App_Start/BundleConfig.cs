using System.Web;
using System.Web.Optimization;

namespace Front_end_dinh_van_hoang_an
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Css").Include(
                 "~/Content/css/font-awesome.min.css",
                 "~/Content/css/owl.carousel.css",
                 "~/Content/css/owl.my_theme.css",
                 "~/Content/css/owl.transitions.css",
                 "~/Content/css/nivo-slider.css",
                 "~/Content/css/animate.css",
                 "~/Content/css/jquery-ui.css",
                 "~/Content/css/jquery.fancybox.css",
                 "~/Content/css/normalize.css",
                 "~/Content/css/bootstrap.min.css",
                 "~/Content/css/custom.css",
                 "~/Content/css/meanmenu.min.css",
                 "~/Content/css/responsive.css",
                 "~/Content/css/main.css",
                 "~/Content/css/style.css"
                 ));
            bundles.Add(new ScriptBundle("~/Js").Include(
                "~/Scripts/js-frontend/vendor/modernizr-2.8.3.min.js",
                "~/Scripts/js-frontend/vendor/jquery-1.11.3.min.js",
                "~/Scripts/js-frontend/bootstrap.min.js",
                "~/Scripts/js-frontend/jquery.meanmenu.js",
                "~/Scripts/js-frontend/jquery.easing.1.3.min.js",
                "~/Scripts/js-frontend/jquery.knob.js",
                "~/Scripts/js-frontend/jquery.fancybox.pack.js",
                "~/Scripts/js-frontend/price-slider.js",
                "~/Scripts/js-frontend/jquery.nivo.slider.pack.js",
                "~/Scripts/js-frontend/wow.js",
                "~/Scripts/js-frontend/nivo-plugin.js",
                "~/Scripts/js-frontend/jquery.scrollUp.js",
                "~/Scripts/js-frontend/owl.carousel.min.js",
                "~/Scripts/js-frontend/plugins.js",
                "~/Scripts/js-frontend/main.js",
                "~/Scripts/js-frontend/jquery.appear.js"
                ));
        }
    }
}
