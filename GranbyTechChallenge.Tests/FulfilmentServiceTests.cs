using GranbyTechChallenge.Models;
using GranbyTechChallenge.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GranbyTechChallenge.Strategies;

namespace GranbyTechChallenge.Tests
{
    [TestFixture]
    public class FulfilmentServiceTests
    {
        [Test]
        public void Process_ShouldFulfilOrder_WhenEnoughStockExists()
        {
            // Arrange
            var stock = new List<StockItem>
        {
            new()
            {
                Id = 1,
                Name = "Controller",
                QuantityOnHand = 10,
                QuantityAllocated = 3
            }
        };

            var template = new TemplateBundle
            {
                Id = 1,
                Name = "Birthday Bundle",
                BundleItems =
                [
                    new TemplateBundleDetail
                {
                    StockItemId = 1,
                    QuantityRequired = 2
                }
                ]
            };

            var order = new Order
            {
                Id = 1,
                OrderNumber = "ORD001",
                TemplateBundle = template,
                Quantity = 3,
                ReceivedDate = DateTime.Today,
                DispatchDeadline = DateTime.Today.AddDays(2)
            };

            var strategy = new FifiFulfilmentStrategy();

            // Act
            var result = strategy.Process(
        new List<Order> { order },
        stock);

            // Assert
            Assert.That(result.FulfilledOrders.Count, Is.EqualTo(1));
        }
    }
}
