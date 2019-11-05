using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public string ReviewTitle { get; set; }
        public string BookReview { get; set; }
        public DateTime Date { get; set; }
       
    }
}
