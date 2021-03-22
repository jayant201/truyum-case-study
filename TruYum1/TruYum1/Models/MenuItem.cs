using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruYum1.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int Price { get; set; }
        public bool Active { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOflaunch { get; set; }
        [Display(Name = "FreeDelivery")]
        public bool FreeDelivery { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}