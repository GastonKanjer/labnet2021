using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNet.TP8.MVC.Models
{
    public class ShippersRequest
    {
        [Key]
        public int ShipperID { get; set; }


        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }


        [StringLength(24)]
        public string Phone { get; set; }
    }
}
