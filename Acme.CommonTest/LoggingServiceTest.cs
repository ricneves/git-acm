using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName="Frodo",
                LastName = "Baggins",
                EmailAddress = "sample@test.com",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "assorted 4 sunflowers",
                CurrentPrice = 18M
            };
            changedItems.Add(product);

            //--Act
            LoggingService.WriteToFile(changedItems);

            //--Assert
            // nothing here to assert
        }
    }
}
