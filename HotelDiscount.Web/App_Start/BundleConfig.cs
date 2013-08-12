using System.Web.Optimization;

namespace HotelDiscount.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/ScriptsBundle").Include(
                "~/Scripts/kendo/2013.2.716/kendo.web.min.js",
                "~/Scripts/kendo/2013.2.716/cultures/kendo.culture.ru-RU.min.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout-kendo.js",
                "~/Scripts/linq.js"));
            bundles.Add(new StyleBundle("~/Content/StylesBundle").Include(
                "~/Content/Styles/default.css"
                ));
            bundles.Add(new StyleBundle("~/Content/kendo/2013.2.716/theme").Include(
                "~/Content/kendo/2013.2.716/kendo.common.min.css",
                "~/Content/kendo/2013.2.716/kendo.metro.min.css"
                ));
        }
    }
}