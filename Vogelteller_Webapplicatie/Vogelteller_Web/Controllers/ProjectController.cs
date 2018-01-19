using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Models;

namespace Vogelteller_Web.Controllers
{
    public class ProjectController : Controller
    {
        ProjectLogic logic = new ProjectLogic();
        // GET: Project
        public ActionResult Index()
        {
            return View(logic.GetAllProjects());
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            if (logic.GetProjectByID(id) != null)
            {
                return View(logic.GetProjectByID(id));
            }
            else
            {
                return HttpNotFound();
            }            
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                logic.NewProject(collection["name"], collection["map"], DateTime.Now, Convert.ToInt32(collection["speciesID"]));
                return RedirectToAction("Index", "Project");
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
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

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
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
