using PacificProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.ViewModel
{
    public class HomePageViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
