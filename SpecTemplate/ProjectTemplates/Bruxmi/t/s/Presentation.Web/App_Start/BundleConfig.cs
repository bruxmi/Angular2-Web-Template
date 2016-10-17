using System.Web;
using System.Web.Optimization;

namespace Presentation.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        private static readonly string npm = "~/node_modules/";

        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/systemjs").Include(
                      "~/systemjs.config.js"));

            bundles.Add(new ScriptBundle("~/bundles/polyfill").Include(
                       npm + "core-js/client/shim.min.js",
                       npm + "zone.js/dist/zone.js",
                       npm + "reflect-metadata/Reflect.js",
                       npm + "systemjs/dist/system.src.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
