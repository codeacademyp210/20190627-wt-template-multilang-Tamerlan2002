
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chimper.Models
{
    public class RealBog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
    }
}