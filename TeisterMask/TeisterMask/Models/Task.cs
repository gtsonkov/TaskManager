using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeisterMask.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Requered]
        public string Title { get; set; }

        [Requered]
        public string Status { get; set; }
    }
}
