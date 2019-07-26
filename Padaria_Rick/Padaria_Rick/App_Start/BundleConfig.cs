﻿using System.Web;
using System.Web.Optimization;

namespace Padaria_Rick
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/inputmask").Include(
            "~/Scripts/jquery.mask*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate.unobtrusive*"));

			bundles.Add(new ScriptBundle("~/bundles/telaPessoa").Include(
				  "~/Scripts/ScriptDeTelas/Tela_Pessoa.js"));

		   bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap*"));

			bundles.Add(new ScriptBundle("~/bundles/popper").Include(
					  "~/Scripts/popper.mim.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
