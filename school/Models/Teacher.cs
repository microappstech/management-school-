using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Teacher
    {

        [Key]
        public int IdTe { get; set; }
        public string nameTe { get; set; }
        public string emailTe { get; set; }
        public string phoneTe { get; set; }
        public string spesialisteT { get; set; }
    }
}