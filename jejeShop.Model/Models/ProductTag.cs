using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jejeShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public int TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag tag { set; get; }
    }
}