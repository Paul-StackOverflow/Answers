using MVCAnswers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAnswers.Controllers
{
    public class Ans34215165Controller : Controller
    {
        // GET: Ans34215165
        [HttpGet]
        public ActionResult Index()
        {
            Ans34215165 db = new Ans34215165();
            List<ctTerminalTimeZone> Model = db.ctTerminalTimeZoneEntities.ToList();
            return View(Model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ctTerminalTimeZone Model = new ctTerminalTimeZone() { HiddenValue = Guid.NewGuid().ToString() };
            using (Ans34215165 db = new Ans34215165())
            {
                db.ctTerminalTimeZoneEntities.Add(Model);
                db.SaveChanges();
            }
            return View(Model);
        }
        [HttpPost]
        public ActionResult Create(ctTerminalTimeZone model)
        {
            if (SaveModel(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            ctTerminalTimeZone Model = new ctTerminalTimeZone();
            using (Ans34215165 db = new Ans34215165())
            {
                Model = db.ctTerminalTimeZoneEntities.Where(var => var.Id.ToString() == id).FirstOrDefault();
                if (Model == null)
                {
                    Model = new ctTerminalTimeZone();
                }
            }
            return View(Model);
        }
        [HttpPost]
        public ActionResult Edit(ctTerminalTimeZone model)
        {
            if (SaveModel(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        private bool SaveModel(ctTerminalTimeZone model)
        {
            bool retValue = false;
            using (Ans34215165 db = new Ans34215165())
            {
                ctTerminalTimeZone ctTTZ = db.ctTerminalTimeZoneEntities.Where(var => var.Id == model.Id).SingleOrDefault();
                if (ctTTZ != null)
                {
                    db.Entry(ctTTZ).CurrentValues.SetValues(model);
                    db.SaveChanges();
                }
                retValue = true;
            }
            return retValue;
        }

        public ActionResult Log()
        {
            Ans34215165 db = new Ans34215165();
            List<ctTerminalTimeZoneChangeLog> Model = db.ctTerminalTimeZoneChangeLogEntities.ToList();
            return View(Model);
        }
    }
}
/*

    try 
    { 
        context.Configuration.AutoDetectChangesEnabled = false; 
 
        // Make many calls in a loop 
        foreach (var blog in aLotOfBlogs) 
        { 
            context.Blogs.Add(blog); 
        } 
    } 
    finally 
    { 
        context.Configuration.AutoDetectChangesEnabled = true; 
    } 
*/
