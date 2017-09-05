using jejeShop.Data.Infrastructure;
using jejeShop.Data.Repositories;
using jejeShop.Model.Models;
using jejeShop.service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jejeShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockunitOfWork;
        private IpostCategoryService _categoryService;
        private List<PostCategory> listCategory;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockunitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object,_mockunitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1 ,Name="DM1", Status=true },
                new PostCategory() {ID=2 ,Name="DM2", Status=true },
                new PostCategory() {ID=3 ,Name="DM3", Status=true },
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;
            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(m=>m.Add(category)).Returns((PostCategory p)=>
            {
                p.ID = 1;
                return p;
            });
            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }

    }
    

}
