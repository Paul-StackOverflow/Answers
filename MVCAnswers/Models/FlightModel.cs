using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MVCAnswers
{
    public class FlightModel
    {
        [Display(Name = "Flight ID")]
        public List<string> IDFLIGHT { get; set; }
        [Display(Name = "Type ID")]
        public List<string> IDTYPE { get; set; }

        public FlightModel()
        {

        }
    }
}