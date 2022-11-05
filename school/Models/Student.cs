using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Student
    {
        [Key]
        public int IdSt { get; set; }
        public string nameSt { get; set; }
        public string emailSt { get; set; }
        public string phoneSt { get; set; }
        public string classeSt { get; set; }
    }
}