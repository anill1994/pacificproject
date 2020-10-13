using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PacificProject.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public string Image { get; set; }
        public string Job { get; set; }
        public string Explanation { get; set; }
    }
}
