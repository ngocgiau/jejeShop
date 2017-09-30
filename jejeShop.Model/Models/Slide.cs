﻿using jejeShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jejeShop.Model.Models
{
    [Table("Slides")]
    public class Slide 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(500)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
        public bool Status { set; get; }
        public string Content { set; get; }
    }
}