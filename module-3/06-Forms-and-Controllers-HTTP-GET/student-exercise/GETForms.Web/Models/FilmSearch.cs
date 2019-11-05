using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearch
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public string Genre { get; set; }

        
    }
}
