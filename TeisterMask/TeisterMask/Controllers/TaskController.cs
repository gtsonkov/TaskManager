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
        public IActionResult index()
        {
            using (var db = new TeisterMaskDbContex())
            {
                var tasks = db.Tasks.ToList();
                return this.View(tasks);
            }
        }
    }
}
