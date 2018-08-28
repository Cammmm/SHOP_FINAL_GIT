using System.Web.Mvc;

namespace ShopCam.Areas.AdminUsers
{
    public class AdminUsersAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminUsers";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminUsers_default",
                "AdminUsers/{controller}/{action}/{id}",
                new { action = "Index", controller= "Home",id = UrlParameter.Optional }
                );
        }
    }
}