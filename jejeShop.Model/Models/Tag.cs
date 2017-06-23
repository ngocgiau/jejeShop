using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jejeShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public int ID { set; get; }

        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Type { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}