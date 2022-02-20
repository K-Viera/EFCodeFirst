using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }
        public string Prueba { get; set; }
        public DateTime Published { get; set; }
    }
}