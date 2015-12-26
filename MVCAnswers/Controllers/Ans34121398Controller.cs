using MVCAnswers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAnswers.Controllers
{
    public class Ans34121398Controller : Controller
    {
        // GET: Ans34121398
        public ActionResult Index(String id)
        {
            List<FlightModel> ViewModel = new List<FlightModel>();
            ViewModel.Add(new FlightModel() { IDTYPE = new List<string>() { "Type1", "Type2", "Type3" }, IDFLIGHT = new List<String>() { "Flight1", "Flight2", "Flight2" } });
            return View(ViewModel);
        }
        [HttpPost]
        public ActionResult Ajouter(int idflight, int idtype)
        {
            
            return null;
        }
    }
}
/*
for (int i = 0;
                    i < Convert.ToInt32(Request.Form["PackageFileCount"]);
                    i++)
            {
                if (Request.Form["File0Mode_" + i] != "sourceFile")
                    throw
                      new Exception("Uploader expects to send original files.");
                HttpPostedFileBase sourceFile;
                sourceFile = Request.Files["File0_" + i];

                Char[] sepDCap = { '_', '.' };
                String[] data = sourceFile.FileName.Split(sepDCap);
                string Jour = data[1];
                string Mois = data[2];
                string Annee = data[3];

                string dateCreat = DateTime.Now.ToString();
                Char[] sepTDate = { '-', '/', ' ' };
                String[] dateCr = dateCreat.Split(sepTDate);
                string Jourdc = dateCr[0];
                string Moisdc = dateCr[1];
                string Anneedc = dateCr[2];

                string pathToCreate = "~/Uploads/" + Anneedc + "/" + Moisdc + "/" + Jourdc;
                if (!Directory.Exists(Server.MapPath(pathToCreate)))
                {
                    Directory.CreateDirectory(Server.MapPath(pathToCreate));
                }
                string dir = Server.MapPath(pathToCreate);

                sourceFile.SaveAs(dir + "/" + sourceFile.FileName);

                DateTime dateCapt = Convert.ToDateTime(Jour + "-" + Mois + "-" + Annee);
                double latitude = Convert.ToDouble(data[4]);
                double altitude = Convert.ToDouble(data[5]);
                string pathImage = pathToCreate;
                double longitude = Convert.ToDouble(data[6]);

                IMAGES img = new IMAGES();

                img.IDFLIGHT = idflight;
                img.IDTYPE = idtype;
                img.DATECAPTURE = dateCapt;
                img.LATITUDE = latitude;
                img.ALTITUDE = altitude;
                img.PATHIMAGE = pathImage;
                img.CREATED = Convert.ToDateTime(dateCreat);
                img.LONGITUDE = longitude;

                ImageService imgSce = new ImageService();
                imgSce.create(img);
            }
            Response.Write("Upload Complete");
*/
