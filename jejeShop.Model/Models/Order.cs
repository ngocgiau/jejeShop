using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jejeShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string CutomerName { set; get; }

        [Required]
        public string CutomerAddress { set; get; }

        [Required]
        public string CutomerEmail { set; get; }

        [Required]
        public string CutomerMobile { set; get; }

        public string CutomerMessage { set; get; }
        public string PaymenMethod { set; get; }

        [Required]
        public string PaymenStatus { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public bool Status { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}