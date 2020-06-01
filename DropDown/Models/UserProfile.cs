using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DropDown.Models
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string UserImage { get; set; }

        public int? CountryId { get; set; }
    }
}