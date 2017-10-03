using AutoMapper;
using jejeShop.Model.Models;
using jejeShop.Service;
using jejeShop.Web.Models;
using System.Web.Mvc;

namespace jejeShop.Web.Controllers
{
    public class ContactDetailController : Controller
    {
        IContactDetailService _contactDetailService;

        public ContactDetailController(IContactDetailService contactDetailService)
        {
            this._contactDetailService = contactDetailService;
        }

        // GET: Contact
        public ActionResult Index()
        {
            var model = _contactDetailService.GetDefaultContact();
            var contactDetailViewModel = Mapper.Map<ContactDetail, ContactDetailViewModel>(model);
            return View(contactDetailViewModel);
        }
    }
}