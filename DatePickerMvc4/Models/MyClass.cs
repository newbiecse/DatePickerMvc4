using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatePickerMvc4.Models
{
    public class MyClass
    {
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter MyDate")]
        public DateTime MyDate { get; set; }
    }
}