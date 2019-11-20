using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1.Models;
namespace Project1.Controllers
{

   
    public class GoalController : Controller
    {
        public static List<Goal> lGoals = new List<Goal>();
        public static List<string> goalTypes = new List<string>();

        
        // GET: Goal
        public ActionResult Index()
        {
            if (!goalTypes.Any())
            {
                goalTypes.Add("Daily");
                goalTypes.Add("Weekly");
                goalTypes.Add("Month");
                goalTypes.Add("Semesterly");
            }
            ViewBag.Types = goalTypes;
            return View(lGoals);
        }

        // GET: Goal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Goal/Create
        public ActionResult Create()
        {
            if (!goalTypes.Any())
            {
                goalTypes.Add("Daily");
                goalTypes.Add("Weekly");
                goalTypes.Add("Month");
                goalTypes.Add("Semesterly");
            }
            ViewBag.Types = goalTypes;
            return View();
        }

        // POST: Goal/Create
        [HttpPost]
        public ActionResult Create(Goal newGoal)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View(newGoal);
                }
                else
                {
                    lGoals.Add(newGoal);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Goal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Goal/Edit/5
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

        // GET: Goal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Goal/Delete/5
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
