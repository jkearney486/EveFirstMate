using System.Web;
using System.Web.Optimization;

namespace EveFirstMate
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-{version}.js"));

            // Global scripts
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/knockout-{version}.debug.js",
                        "~/Scripts/knockout.mapping.debug.js",
                        "~/Scripts/knockout-postbox.js",
                        "~/Scripts/main.js"));

            // Global scripts w/ ko 3.0.0 beta
            bundles.Add(new ScriptBundle("~/bundles/beta").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/knockout-{version}beta.debug.js",
                        "~/Scripts/knockout.mapping.debug.js",
                        "~/Scripts/knockout-postbox.js",
                        "~/Scripts/main.js"));

            // Knockout & Knockout-mapping
            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                                    "~/Scripts/knockout-{version}.debug.js",
                                    "~/Scripts/knockout.mapping.debug.js"));

            // Global styles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                                    "~/Content/normalize.css",
                                    "~/Content/themes/smoothness-mod/jquery-ui-{version}.css",
                                    "~/Content/main.css"));
        }
    }
}
