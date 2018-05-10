using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeCalculator;
using ElectronicColorCode.Models;

namespace ElectronicColorCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                ColorSelector selectOnLoad = new ColorSelector();
                return View(selectOnLoad);
            }
            catch (Exception ex)
            {
                return Json(new { error = "Error when calculating resistance value: " + ex.Message });
            }

        }


        [HttpPost]
        public ActionResult GetResistanceValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            try
            {
                // initialize interface object 
                IOhmValueCalculator objResistance = new CalculateResistance();

                // Call the method that calculates resistance value in ColorCodeCalculator class library 
                double resultObject = objResistance.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);

                /// return JSON response
                return Json(new { value = resultObject });
            }
            catch (Exception ex)
            {
                return Json(new { error = "Error when calculating resistance value: " + ex.Message });
            }
        }

    }
}