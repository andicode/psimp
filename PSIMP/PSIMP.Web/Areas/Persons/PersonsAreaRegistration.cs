using System.Web.Mvc;

namespace PSIMP.Web.Areas.Persons
{
    public class PersonsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Persons";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Persons_default",
                "Persons/{controller}/{action}/{id}",
                new {controller="Default", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
