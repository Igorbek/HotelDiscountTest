using System.Web.Optimization;

namespace HotelDiscount.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts").Include(
                "~/Scripts/kendo/2013.2.716/kendo.web.min.js",
                "~/Scripts/kendo/2013.2.716/cultures/kendo.culture.ru-RU.min.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout-kendo.js",
                "~/Scripts/linq.js"));
            bundles.Add(new StyleBundle("~/Styles").Include(
                "~/Content/kendo/2013.2.716/kendo.common.min.css",
                //"~/Content/kendo/2013.2.716/kendo.default.min.css",
                "~/Content/kendo/2013.2.716/kendo.metro.min.css",
                "~/Content/Styles/default.css"
                ));

            //BundleTable.EnableOptimizations = false;
        }
    }
}