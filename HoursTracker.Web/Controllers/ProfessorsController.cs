using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoursTracker.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoursTracker.Web.Controllers
{
    public class ProfessorsController : Controller
    {
        // GET: Professors
        public ActionResult Index()
        {

            var professors = new[]
            {
                new ProfessorViewModel
                {
                    Name = "William",
                    Career = "Sistemas",
                    LastName = "Apellido"
                },
                new ProfessorViewModel
                {
                    Name = "William 2",
                    Career = "Sistemas 2",
                    LastName = "Apellido 2"
                }
            };

            return View(professors);
        }

        // GET: Professors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Professors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Professors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Professors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Professors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Professors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}