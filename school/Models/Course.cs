using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string nameCo { get; set; }
        public int nbrH { get; set; }
        public string image { get; set; }
        public string active { get; set; }
        public string spesialisteCo { get; set; }
    }
}