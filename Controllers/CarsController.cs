using Cpuntries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cpuntries.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            var listOfCars = new List<CarsRank>()
            {
                new CarsRank
                {
                    Car = "2020 Volkswagen GTI",
                    Price = "$28,595 - $37,295",
                    Score = "8.6",
                    MPG = "24 CITY/32 HWY"
                },
                new CarsRank
                {
                    Car = "2020 Honda Civic",
                    Price = "$19,850 - 28,950",
                    Score = "8.5",
                    MPG = "30 City/38 Hwy"
                },
                new CarsRank
                {
                    Car = "2020 Mazda Mazda3",
                    Price = "$21,500 - $28,900",
                    Score = "8.5",
                    MPG = "26 City / 35 Hwy"
                },
                new CarsRank
                {
                    Car = "2020 Kia Forte",
                    Price = "$17,890 - $23,090",
                    Score = "8.3",
                    MPG = "31 city /41 HWY"
                },
                new CarsRank
                {
                    Car = "2020 Volkswagen Golf",
                    Price = "$23,195 - $23,995",
                    Score = "8.3",
                    MPG = "29 City / 35Hwy"
                }
            };
            return View(listOfCars);
        }

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cars/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
