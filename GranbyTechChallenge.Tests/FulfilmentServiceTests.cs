using GranbyTechChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranbyTechChallenge.Tests
{
    public class FulfilmentServiceTests
    {
        [Fact]
        public void CanFulfilOrder_ShouldReturnTrue_WhenEnoughStockExists()
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
                Quantity = 3
            };

            var service = new FulfilmentService();

            // Act
            var result = service.CanFulfilOrder(order, template, stock);

            // Assert
            result.Should().BeTrue();
        }
    }
}
