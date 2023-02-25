using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
{
    public static class BundleConfig
    {
        public static void RegiterBundles(BundleCollection bundles)
        {
            //FolderCSS
            bundles.Add(new StyleBundle("~/bundles/bootstrap.min/css").Include(
                "~/Content/assets/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/assets/css/style.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/material/css").Include(
                "~/Content/assets/css/materialdesignicons.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/icon/css").Include(
                "~/Content/assets/css/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/variable/scss").Include(
                "~/Content/assets/scss/_variable.scss", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/main/scss").Include(
                "~/Content/assets/scss/style.scss", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/site/css").Include(
                "~/Content/Site.css", new CssRewriteUrlTransform()));

            //FolderJs
            bundles.Add(new ScriptBundle("~/bundles/app/scss").Include(
                "~/Content/assets/js/app.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/bundle/scss").Include(
                "~/Content/assets/js/bootstrap.bundle.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/counter/scss").Include(
                "~/Content/assets/js/counter.init.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/easing/scss").Include(
                "~/Content/assets/js/jquery.easing.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/min/scss").Include(
                "~/Content/assets/js/jquery.min.js", new CssRewriteUrlTransform()));
            bundles.Add(new ScriptBundle("~/bundles/crollspy/scss").Include(
                "~/Content/assets/js/scrollspy.min.js", new CssRewriteUrlTransform()));

            //FolderPhp
            bundles.Add(new ScriptBundle("~/bundles/contact/php").Include(
                "~/Content/assets/php/contact.php", new CssRewriteUrlTransform()));
        }
    }
}