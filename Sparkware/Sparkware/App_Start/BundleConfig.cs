﻿using System.Web;
using System.Web.Optimization;

namespace Sparkware {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/DatePickerReady.js"));

            bundles.Add(new ScriptBundle("~/bundles/handlebars").Include(
                       "~/Scripts/handlebars.js"));

            bundles.Add(new ScriptBundle("~/bundles/Common").Include(
                       "~/Scripts/Common/Ajax.js",
                       "~/Scripts/Common/HandlebarsRenderer.js",
                       "~/Scripts/Script.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker3.css",
                      "~/Content/site.css"));
        }
    }
}