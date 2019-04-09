using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeisterMask.Data;

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

            return View("Index");
        }
    }
}
