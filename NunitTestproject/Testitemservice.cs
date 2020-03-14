using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ItemServices.Models;
using ItemServices.repositories;

namespace NunitTestproject
{
    [TestFixture]
    class Testitemservice
    {
        ItemRep _repo;
        [SetUp]
        public void SetUp()
        {
            _repo = new ItemRep(new ShopDBContext());
        }
        [Test]
        public void TestGetAllItems()
        {
            var result = _repo.GetAllItems();
            Assert.IsNotNull(result);
            Assert.Greater(result.Count, 7);
        }
        [Test]
        public void TestGetById()
        {
            var result = _repo.GetById("111");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestAddItems()
        {
            _repo.AddItems(new Items()
            {
                Itemid = "1001",
                Name = "ABCD",
                Price = 34,
                Stock = 100
            });
            var result = _repo.GetById("1001");
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestDelete()
        {
            _repo.delete("1001");
            var result = _repo.GetById("1001");
            Assert.Null(result);
               
        }
        [Test]
        public void TestUpdate()
        {
            Items item = _repo.GetById("1001");
            item.Price = 200;
            _repo.update(item);
            Items item1 = _repo.GetById("1001");
            Assert.AreSame(item,item1);

        }

    }
}
