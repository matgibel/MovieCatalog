using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public List<Video> Videos { get; set; }
    }
}
