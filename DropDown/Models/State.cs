using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace DropDown.Models
{
    public class State
    {
        [Key]
        public int state_id { get; set; }
        public string name { get; set; }

        [ForeignKey("Country")]
        public int country_id { get; set; }
        public Country Country { get; set; }

        public IEnumerable<City> Cities { get; set; }

    }
}