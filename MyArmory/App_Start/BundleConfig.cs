using System.Web;
using System.Web.Optimization;

namespace MyArmory
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // css
            bundles.Add(new StyleBundle("~/public/css").Include("~/public/css/bootstrap.css"));

            // js
            bundles.Add(new ScriptBundle("~/public/js").Include("~/public/js/jquery*",
                                                                "~/public/js/bootstrap.js"));
        }
    }
}