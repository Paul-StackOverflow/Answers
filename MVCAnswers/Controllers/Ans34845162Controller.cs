using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAnswers.Controllers
{
    public class Ans34845162Controller : Controller
    {

        // GET: Ans34845162
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddUnit(String usrCode)
        {
            var units = unitsClient.GetAllunits();
            var allunitsCode = (from s in units select s.unitCode).ToList();
            var thisUnitCode = (from s in db.Units
                                where s.UsrCode == usrCode
                                select s.UnitCode).ToList();
            var notGot = allunitsCode.Except(thisUnitCode);
            List<unitsummaryDTO> list = UnitList(units, notGot);
            ViewBag.unitCode = new SelectList(list, "unitCode", "unitTitle");
            var model = new UserUnit { UsrCode = usrCode };
            return View("AddUnit", model);
        }

        private List<unitsummaryDTO> UnitList(unitsService.unitsDTO[] units, IEnumerable<string> notGot)
        {
            var allunits = unitsClient.GetAllunits();
            var allunitsCode = (from s in allunits select s.unitCode).ToList();
            IEnumerable<String> list1 = allunitsCode;
            IEnumerable<String> list2 = notGot;
            var listFinal = list1.Union(list2).ToList();

            return listFinal.Select(x => new unitsummaryDTO() { unitCode = x }).ToList();
        }
    }

    internal class UserUnit
    {
        public string UsrCode { get; set; }
    }

    internal class unitsummaryDTO
    {
        public unitsummaryDTO()
        {

        }
    }
    internal class unitsClient
    {
        public unitsClient()
        {

        }

        internal static object GetAllunits()
        {
            throw new NotImplementedException();
        }
    }
    internal static class unitsService
    {
        internal class unitsDTO
        {
        }
    }
}