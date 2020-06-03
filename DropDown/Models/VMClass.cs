using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDown.Models
{
    public class VMClass
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}