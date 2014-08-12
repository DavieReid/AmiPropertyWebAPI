using System.Web;
using System.Web.Optimization;

namespace AmiProperty
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Clear all items from the default ignore list to allow minified CSS and JavaScript files to be included in debug mode
            bundles.IgnoreList.Clear();

            // Add back the default ignore list rules sans the ones which affect minified files and debug mode
            bundles.IgnoreList.Ignore("*.intellisense.js");
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);


            //include ami property scripts
            bundles.Add(new ScriptBundle("~/bundles/amiScripts").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/ui-bootstrap-tpls-0.10.0.min.js",
                         "~/Scripts/Custom/Controllers/controllers.js",
                         "~/Scripts//bootstrap.min.js",
                         "~/Scripts/Custom/amiProperty.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/amiproperty.css",
                         "~/Content/bootstrap-theme.min.css",
                          "~/Content/bootstrap.min.css"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
        }
    }
}