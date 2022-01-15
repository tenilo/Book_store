using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_WebApp.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }

    }
}