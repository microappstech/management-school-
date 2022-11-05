using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace school.Models
{
    public class Room
    {
        [Key]
        public int IdRom { get; set; }
        public int Number { get; set; }
    }
}