using System;
using System.ComponentModel.DataAnnotations;

namespace jejeShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedData { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdateData { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}