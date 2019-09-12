using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCascadingDropdownList.Controllers
{
    public class HomeController : Controller
    {
        private static List<SelectListItem> continents;
        private static List<SelectListItem> countries;
        private static List<SelectListItem> cities;

        public ActionResult Index()
        {
            continents = new List<SelectListItem>();
            continents.Add(new SelectListItem { Text = "Select continent", Value = "0" });
            continents.Add(new SelectListItem { Text = "Europe", Value = "1" });
            continents.Add(new SelectListItem { Text = "North America", Value = "2" });
            continents.Add(new SelectListItem { Text = "South America", Value = "3" });
            ViewData["continents"] = continents;

            countries = new List<SelectListItem>();
            countries.Add(new SelectListItem { Text = "Select country", Value = "0" });
            ViewData["countries"] = countries;

            cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "Select city", Value = "0" });
            ViewData["cities"] = cities;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetCountries(string selectedValue)
        {
            countries = new List<SelectListItem>();
            countries.Add(new SelectListItem { Text = "Select country", Value = "0" });
            switch (selectedValue)
            {
                case "1":
                    countries.Add(new SelectListItem { Text = "United Kingdom", Value = "1" });
                    countries.Add(new SelectListItem { Text = "Italy", Value = "2" });
                    countries.Add(new SelectListItem { Text = "Greece", Value = "3" });
                    break;
                case "2":
                    countries.Add(new SelectListItem { Text = "USA", Value = "4" });
                    countries.Add(new SelectListItem { Text = "Canada", Value = "5" });
                    countries.Add(new SelectListItem { Text = "Mexico", Value = "6" });
                    break;
                case "3":
                    countries.Add(new SelectListItem { Text = "Brazil", Value = "7" });
                    countries.Add(new SelectListItem { Text = "Colombia", Value = "8" });
                    countries.Add(new SelectListItem { Text = "Argentina", Value = "9" });
                    break;
            }

            return Json(new SelectList(countries, "Value", "Text"));
        }

        public JsonResult GetCities(string selectedValue)
        {
            cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "Select city", Value = "0" });
            switch (selectedValue)
            {
                case "1":
                    cities.Add(new SelectListItem { Text = "Glasgow", Value = "1" });
                    cities.Add(new SelectListItem { Text = "London", Value = "2" });
                    cities.Add(new SelectListItem { Text = "Edinburgh", Value = "3" });
                    break;
                case "2":
                    cities.Add(new SelectListItem { Text = "Milan", Value = "4" });
                    cities.Add(new SelectListItem { Text = "Rome", Value = "5" });
                    break;
                case "3":
                    cities.Add(new SelectListItem { Text = "Athens", Value = "6" });
                    cities.Add(new SelectListItem { Text = "Sparta", Value = "7" });
                    break;
                case "4":
                    cities.Add(new SelectListItem { Text = "Liberty City", Value = "8" });
                    cities.Add(new SelectListItem { Text = "Los Santos", Value = "9" });
                    cities.Add(new SelectListItem { Text = "Vice City", Value = "10" });
                    break;
                case "5":
                    cities.Add(new SelectListItem { Text = "Toronto", Value = "11" });
                    cities.Add(new SelectListItem { Text = "Vancouver", Value = "12" });
                    cities.Add(new SelectListItem { Text = "Ottawa", Value = "13" });
                    break;
                case "6":
                    cities.Add(new SelectListItem { Text = "Mexico City", Value = "14" });
                    cities.Add(new SelectListItem { Text = "Cancun", Value = "15" });
                    break;
                case "7":
                    cities.Add(new SelectListItem { Text = "Rio de Janeiro", Value = "16" });
                    cities.Add(new SelectListItem { Text = "Brasilia", Value = "17" });
                    break;
                case "8":
                    cities.Add(new SelectListItem { Text = "Bogota", Value = "18" });
                    cities.Add(new SelectListItem { Text = "Cali", Value = "19" });
                    break;
                case "9":
                    cities.Add(new SelectListItem { Text = "Beunos Aries", Value = "20" });
                    cities.Add(new SelectListItem { Text = "Rosario", Value = "21" });
                    break;
            }

            return Json(new SelectList(cities, "Value", "Text"));
        }
    }
}