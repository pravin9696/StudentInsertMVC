using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInsertMVC.Models
{
    public class Lang
    {
        [Display(Name ="Hindi678")]
        public bool hindi { get; set; }
        [Display(Name = "English123")]
        public bool english { get; set; }
        [Display(Name = "Marathi234")]
        public bool marathi { get; set; }
    }
}