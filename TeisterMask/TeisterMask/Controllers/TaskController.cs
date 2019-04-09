using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult index()
        {
            using (var db = new TeisterMaskDbContex())
            {
                var tasks = db.Tasks.ToList();
                return this.View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(string title,string status)
        {
            if (string.IsNullOrEmpty(title))
            {
                return RedirectToAction("Index");
            }

            using (var db = new TeisterMaskDbContex())
            {
                Task task = new Task
                {
                    Title = title,
                    Status = status
                };
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            using (var db = new TeisterMaskDbContex())
            {
                var taskToEdit = db.Tasks.Find(Id);
                return View(taskToEdit);
            }
        }
        [HttpPost]
        public IActionResult Edit(Task task)
        {
            using (var db = new TeisterMaskDbContex())
            {
                db.Tasks.Update(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delite(int Id)
        {
            using (var db = new TeisterMaskDbContex())
            {
                var taskToDelite = db.Tasks.Find(Id);
                return View(taskToDelite);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var db = new TeisterMaskDbContex())
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
