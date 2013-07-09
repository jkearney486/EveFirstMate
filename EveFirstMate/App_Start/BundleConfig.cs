using System.Web;
using System.Web.Optimization;

namespace EveFirstMate
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libs/modernizr-{version}.js"));

            // Global scripts
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                        "~/Scripts/jquery/jquery-{version}.js",
                        "~/Scripts/jquery/jquery-ui-{version}.js",
                        "~/Scripts/knockout/knockout-{version}.debug.js",
                        "~/Scripts/knockout/knockout.mapping.debug.js",
                        "~/Scripts/knockout/knockout-postbox.js",
                        "~/Scripts/main.js"));

            // Global scripts w/ ko 3.0.0 beta
            bundles.Add(new ScriptBundle("~/bundles/beta").Include(
                        "~/Scripts/jquery/jquery-{version}.js",
                        "~/Scripts/jquery/jquery-ui-{version}.js",
                        "~/Scripts/knockout/knockout-{version}beta.debug.js",
                        "~/Scripts/knockout/knockout.mapping.debug.js",
                        "~/Scripts/knockout/knockout-postbox.js",
                        "~/Scripts/main.js"));

            // Knockout & Knockout-mapping
            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                                    "~/Scripts/knockout/knockout-{version}.debug.js",
                                    "~/Scripts/knockout/knockout.mapping.debug.js"));

            // Global styles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                                    "~/Content/normalize.css",
                                    "~/Content/themes/smoothness-mod/jquery-ui-{version}.css",
                                    "~/Content/main.css"));
        }
    }
}