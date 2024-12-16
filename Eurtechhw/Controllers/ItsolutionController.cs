using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using Itsolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Models;
using System.Runtime.Remoting.Messaging;
using Headermodel.Models;
using Footer.Models;
using Testimonials.Models;

namespace Eurtechhw.Controllers
{
    public class ItsolutionController : Controller
    {
       
        public ActionResult Index()
        {
           

                var Model = new TestModel()
                {

                    Item = RenderingContext.Current?.Rendering.Item

                };

                return View("/Views/Itsolution/Index.cshtml",Model);
            
           
        }

        public ActionResult Servicecomponent()
        {


            var Model = new ServiceTest()
            {

                Item = RenderingContext.Current?.Rendering.Item

            };

            return View("/Views/Itsolution/Service.cshtml", Model);


        }
        public ActionResult Headercomponent()
        {

            var Model = new Headermodels()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Itsolution/Header.cshtml", Model);

       
        }
        public ActionResult Footercomponent()
        {

            var Model = new Footermodel()
            {
                Item = RenderingContext.Current?.Rendering.Item
            };
            return View("/Views/Itsolution/Footer.cshtml", Model);

        }
        public ActionResult Testimonials()

        {

            var Model = new Testimonialsmodel()

            {

                Item = RenderingContext.Current?.Rendering.Item

            };

            return View("/Views/Itsolution/Testimonials.cshtml", Model);

        }

    }
}