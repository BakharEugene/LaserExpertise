using System.Web.Mvc;

namespace LaserExpertise.Pictures.WebUI.Areas.BusinessItem
{
    public class PicturesRegistration
    {
        public static void RegisterPictures(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}