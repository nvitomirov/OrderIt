using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderIt.DataAccess;

namespace OrderIt.DataAccess.Test
{
    [TestClass]
    public class DataContextTest
    {
        [TestMethod]
        public void ContextHasEntities_Test()
        {
            var context = new DatabaseContext();
            var customers = context.Customers;
            var products = context.Products;
            var orders = context.Orders;
            
            Assert.IsNotNull(customers);
            Assert.IsNotNull(products);
            Assert.IsNotNull(orders);
        }
    }
}
