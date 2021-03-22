using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TruYum1.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}