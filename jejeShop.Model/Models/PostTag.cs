using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jejeShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public int TagsID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("tagID")]
        public virtual Tag Tag { set; get; }
    }
}