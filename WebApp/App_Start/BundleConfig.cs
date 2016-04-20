using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //<script type="text/javascript" src="/unify/assets/plugins/jquery/jquery.min.js"></script>
            //<script type="text/javascript" src="/unify/assets/plugins/jquery/jquery-migrate.min.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/unify/assets/plugins/jquery/jquery.min.js",
                        "~/unify/assets/plugins/jquery/jquery-migrate.min.js"));

            //<script type="text/javascript" src="/unify/assets/plugins/bootstrap/js/bootstrap.min.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/unify/assets/plugins/bootstrap/js/bootstrap.min.js"));

            //            <script type="text/javascript" src="/unify/assets/plugins/back-to-top.js"></script>
            //<script type="text/javascript" src="/unify/assets/plugins/smoothScroll.js"></script>
            //<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=true"></script>
            //<script type="text/javascript" src="/unify/assets/plugins/gmap/gmap.js"></script>
            //<script type="text/javascript" src="/unify/assets/plugins/owl-carousel/owl-carousel/owl.carousel.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                      "~/unify/assets/plugins/back-to-top.js",
                      "~/unify/assets/plugins/smoothScroll.js",
                      "~/unify/assets/plugins/gmap/gmap.js",
                      "~/unify/assets/plugins/owl-carousel/owl-carousel/owl.carousel.js"));

            //            <!-- JS Customization -->
            //<script type="text/javascript" src="/unify/assets/js/custom.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/jscustom").Include(
                      "~/unify/assets/js/custom.js"));


            //            <!-- JS Page Level -->
            //<script type="text/javascript" src="/unify/assets/js/app.js"></script>
            //<script type="text/javascript" src="/unify/assets/js/pages/page_contacts.js"></script>
            //<script type="text/javascript" src="/unify/assets/js/plugins/owl-carousel.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/pagelevel").Include(
                      "~/unify/assets/js/app.js",
                      "~/unify/assets/js/pages/page_contacts.js",
                      "~/unify/assets/js/plugins/owl-carousel.js"));

            
            //<script type="text/javascript" src="/scripts/yandex.js"></script>
            bundles.Add(new ScriptBundle("~/bundles/yandex").Include(
                        "~/scripts/yandex.js"));

            bundles.Add(new ScriptBundle("~/bundles/google").Include(
            "~/scripts/google.js"));

            bundles.Add(new ScriptBundle("~/bundles/price").Include(
                        "~/Scripts/Price.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            //            <!-- CSS Global Compulsory -->
            //<link rel="stylesheet" href="unify/assets/plugins/bootstrap/css/bootstrap.min.css">
            //<link rel="stylesheet" href="unify/assets/css/style.css">
            bundles.Add(new StyleBundle("~/unify/globalcss").Include(
                    "~/unify/assets/plugins/bootstrap/css/bootstrap.min.css",
                    "~/unify/assets/css/style.css"));


            //    <!-- CSS Header and Footer -->
            //<link rel="stylesheet" href="unify/assets/css/headers/header-default.css">
            //<link rel="stylesheet" href="unify/assets/css/footers/footer-v1.css">
            bundles.Add(new StyleBundle("~/unify/headfoot").Include(
                    "~/unify/assets/css/headers/header-default.css",
                    "~/unify/assets/css/footers/footer-v1.css"));


            //            <!-- CSS Implementing Plugins -->
            //<link rel="stylesheet" href="unify/assets/plugins/animate.css">
            //<link rel="stylesheet" href="unify/assets/plugins/line-icons/line-icons.css">
            //<link rel="stylesheet" href="unify/assets/plugins/font-awesome/css/font-awesome.min.css">
            //<link rel="stylesheet" href="unify/assets/plugins/parallax-slider/css/parallax-slider.css">
            //<link rel="stylesheet" href="unify/assets/plugins/owl-carousel/owl-carousel/owl.carousel.css">
            bundles.Add(new StyleBundle("~/unify/csspluguns").Include(
                    "~/unify/assets/plugins/animate.css",
                    "~/unify/assets/plugins/line-icons/line-icons.css",
                    "~/unify/assets/plugins/font-awesome/css/font-awesome.min.css",
                    "~/unify/assets/plugins/parallax-slider/css/parallax-slider.css",
                    "~/unify/assets/plugins/owl-carousel/owl-carousel/owl.carousel.css"));


            //<link rel="stylesheet" href="unify/assets/css/pages/pricing/pricing_v1.css">
            bundles.Add(new StyleBundle("~/unify/pricing").Include(
                    "~/unify/assets/css/pages/pricing/pricing_v1.css",
                    "~/unify/assets/css/pages/pricing/pricing_v8.css"));


            //    <!-- CSS Customization -->
            //<link rel="stylesheet" href="unify/assets/css/custom.css">
            bundles.Add(new StyleBundle("~/unify/custom").Include(
                    "~/unify/assets/css/custom.css"));

            //        <!-- CSS Customization theme color -->
            //<link rel="stylesheet" href="unify/assets/css/theme-colors/blue.css">
            bundles.Add(new StyleBundle("~/unify/color").Include(
                    "~/unify/assets/css/theme-colors/blue.css"));

        }
    }
}
