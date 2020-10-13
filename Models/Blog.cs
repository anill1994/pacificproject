using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
    }
}
