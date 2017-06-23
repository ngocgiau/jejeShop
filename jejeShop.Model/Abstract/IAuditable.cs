using System;

namespace jejeShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedData { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateData { set; get; }
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}