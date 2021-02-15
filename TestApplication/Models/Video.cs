using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }
        public String ImageUrl { get; set; }
        public String ShortDescription { get; set; }
        public String LongDescription { get; set; }

        public decimal Price { get; set; }
        public bool InStock { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
