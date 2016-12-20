using MVCAnswers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAnswers.Controllers
{
    public class Ans34536592Controller : Controller
    {
        // GET: Ans34536592
        public ActionResult Index()
        {
            //List<Ans34536592> Model = new List<Ans34536592>()
            //{
            //    ,
            //    new Models.Ans34536592() { Data_RemoveAt = 2, Operation = Models.LinkListOperation.RemoveAll },
            //    new Models.Ans34536592() { Data_RemoveAt = 3, Operation = Models.LinkListOperation.RemoveAt },
            //    new Models.Ans34536592() { Data_RemoveAt = 4, Operation = Models.LinkListOperation.RemoveOne },
            //    new Models.Ans34536592() { Data_RemoveAt = 5, Operation = Models.LinkListOperation.Submit }
            //};
            Ans34536592 Model = new Ans34536592() { Data_RemoveAt = 12, Operation = Models.LinkListOperation.AddOne };
            //var body = new[] {

            //new
            //{
            //    accountId = 123,
            //    reportType = 1,
            //    reportTypeDesc = "Daily"
            //},
            //   new
            //{
            //    accountId = 123,
            //    reportType = 1,
            //    reportTypeDesc = "Daily"
            //},
            //   new
            //{
            //   accountId = 123,
            //   reportType = 1,
            //   reportTypeDesc = "Daily"
            //}, };

            return View(Model);
        }
        [HttpPost]
        public ActionResult Index(Ans34536592 model)
        {
            var stuff = Request["RBSelected"];
            //List<Ans34536592> Model = new List<Ans34536592>()
            //{
            //    ,
            //    new Models.Ans34536592() { Data_RemoveAt = 2, Operation = Models.LinkListOperation.RemoveAll },
            //    new Models.Ans34536592() { Data_RemoveAt = 3, Operation = Models.LinkListOperation.RemoveAt },
            //    new Models.Ans34536592() { Data_RemoveAt = 4, Operation = Models.LinkListOperation.RemoveOne },
            //    new Models.Ans34536592() { Data_RemoveAt = 5, Operation = Models.LinkListOperation.Submit }
            //};
            Ans34536592 Model = new Ans34536592() { Data_RemoveAt = 1, Operation = Models.LinkListOperation.AddOne };

            List<SelectListItem> Items = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                     Text = "The Selected",
                     Value = "1",
                      Selected = 1 == 1
                }
            };

            //IEnumerable<SelectListItem> unitCoreTypes = this.UnitCoreTypes
            //        .Where(uct => uct.CourseCoreTypeId == this.CourseCoreTypeId)
            //        .Select(uct => new SelectListItem
            //        {
            //            Value = uct.Id.ToString(),
            //            Text = uct.Name,
            //            Selected = SomeBusinessLogicThatIsTrueOrFalse()
            //        });
            return View(Model);
        }

        private bool SomeOperationThatIsTrueOrFalse()
        {
            throw new NotImplementedException();
        }
    }
}