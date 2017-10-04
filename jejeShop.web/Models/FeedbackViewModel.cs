using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jejeShop.Web.Models
{
    public class FeedbackViewModel
    {

        public int ID { set; get; }

        [MaxLength(250, ErrorMessage = "Tên không được quá 250 ký tự")]
        [Required(ErrorMessage = "Bạn chưa điền tên đăng nhập kìa")]
        public string Name { set; get; }

        [MaxLength(250, ErrorMessage = "Email dài quá à ít ít thôi nek (<249)")]
        public string Email { set; get; }

        [MaxLength(500, ErrorMessage = "Tin nhắn dài quá à ít ít thôi nek (<500)")]
        public string Message { set; get; }

        public DateTime CreatedDate { set; get; }

        [Required(ErrorMessage = "Phải nhập trạng thái nữa nak!")]
        public bool Status { set; get; }

        public ContactDetailViewModel ContactDetail { set; get; }
    }
}