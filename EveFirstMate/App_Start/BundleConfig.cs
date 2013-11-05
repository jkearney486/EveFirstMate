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
                        "~/Scripts/knockout-{version}.js",
                        "~/Scripts/knockout-postbox.js",
                        "~/Scripts/knockout-delegatedEvents.js",
                        "~/Scripts/knockout-extensions.js",
                        "~/Scripts/jquery-{version}.min.js",
                        "~/Scripts/knockout-{version}.min.js",
                        "~/Scripts/knockout-postbox.min.js",
                        "~/Scripts/knockout-delegatedEvents.min.js",
                        "~/Scripts/main.js"));

            // Global styles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                                    "~/Content/normalize.css",
                                    "~/Content/main.css"));
        }
    }
}
