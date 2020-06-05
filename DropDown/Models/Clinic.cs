using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDown.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public City City { get; set; }

        public Category Category { get; set; }


    }
}