using AutoMapper;
using jejeShop.Model.Models;
using jejeShop.Service;
using jejeShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jejeShop.Web.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        
            IPageService _pageService;
            public PageController(IPageService pageService)
            {
                this._pageService = pageService;
            }
            // GET: Page
            public ActionResult Index(string alias)
            {
                var page = _pageService.GetByAlias(alias);
                var model = Mapper.Map<Page, PageViewModel>(page);
                return View(model);
            }
        }
    
}