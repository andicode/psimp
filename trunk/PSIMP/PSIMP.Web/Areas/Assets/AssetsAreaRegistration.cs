using System.Web.Mvc;

namespace PSIMP.Web.Areas.Assets
{
    public class AssetsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Assets";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Assets_default",
                "Assets/{controller}/{action}/{id}",
                new {controller="Default", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "PSIMP.Web.Areas.Assets.Controllers" }
            );
        }
    }
}
