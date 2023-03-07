using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hrutik.Models
{
    public class Product
    {
        [Key]
        [Required]
        [DisplayName("ProductID")]
        public int ProductID { get; set; }

        [Required]
        [DisplayName("ProductName")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("CategoryID")]
        public int CategoryID { get; set; }

        [Required]
        [DisplayName("CategoryName")]
        public string CategoryName { get; set; }
    }
}