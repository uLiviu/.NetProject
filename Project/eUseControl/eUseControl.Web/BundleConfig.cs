using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundels(BundleCollection bundles)
        {
            //Vendor CSS Bundle
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap-icons/css").Include(
                "~/Content/vendor/bootstrap-icons/bootstrap-icons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/boxicons/css").Include(
                "~/Content/vendor/boxicons/boxicons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/quill.snow/css").Include(
                "~/Content/vendor/quill/quill.snow.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/quill.bubble/css").Include(
                "~/Content/vendor/quill/quill.bubble.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/remixicon/css").Include(
                "~/Content/vendor/remixicon/remixicon.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/simple-datatables/css").Include(
                "~/Content/vendor/simple-datatables/style.css", new CssRewriteUrlTransform()));
            //Template Main CSS File
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/css/dark-style.css", new CssRewriteUrlTransform()));

            //Vendor JS bundle
            bundles.Add(new ScriptBundle("~/bundles/apexcharts/js").Include(
                "~/Scripts/vendor/apexcharts/apexcharts.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/chart/js").Include(
                "~/Scripts/vendor/chart.js/chart.umd.js"));
            bundles.Add(new ScriptBundle("~/bundles/echarts/js").Include(
                "~/Scripts/vendor/echarts/echarts.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/quill/js").Include(
                "~/Scripts/vendor/quill/quill.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/simple-datatables/js").Include(
                "~/Scripts/vendor/simple-datatables/simple-datatables.js"));
            bundles.Add(new ScriptBundle("~/bundles/tinymce/js").Include(
                "~/Scripts/vendor/tinymce/tinymce.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/validate/js").Include(
                "~/Scripts/vendor/php-email-form/validate.js"));

            //Template Main JS File
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                "~/Scripts/js/main.js"));
        }
    }
}