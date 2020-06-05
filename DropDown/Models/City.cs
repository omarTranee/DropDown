using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDown.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }

        public int state_id { get; set; }

        public State state { get; set; }
        public IEnumerable<Clinic> Clinics { get; set; }


    }
}