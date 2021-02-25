using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyClubManager.Models
{
    public class Contact
    {
        public string Phone { get; set; }

        public string Fax { get; set; }

        [DisplayName("Email Address")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter a valid Email Address.", AllowEmptyStrings = false)]
        public string Email1 { get; set; }

        [DisplayName("Email Address")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter a valid Email Address.", AllowEmptyStrings = false)]
        public string Email2 { get; set; }



    }
}