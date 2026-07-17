using GranbyTechChallenge.Interfaces;
using GranbyTechChallenge.Models;
using GranbyTechChallenge.Models.Results;
using GranbyTechChallenge.Services;
using static GranbyTechChallenge.Services.FulfilmentService;

namespace GranbyTechChallenge.Strategies
{
    public class FifiFulfilmentStrategy : IOrderFulfilmentStrategy
    {
        public FulfilmentResult Process(IEnumerable<Order> orders, IList<StockItem> stockItems)
        {
            var result = new FulfilmentResult();

            var service = new FulfilmentService();

            foreach (var order in orders.OrderBy(o => o.ReceivedDate))// First In First Out
            {
                if (service.CanFulfilOrder(order, order.TemplateBundle,stockItems))// Do we have enough stock?
                {
                    service.AllocateStock(order, order.TemplateBundle, stockItems);

                    result.FulfilledOrders.Add(order);
                }
                else
                {
                    result.UnfulfilledOrders.Add(order);
                }
            }

            return result;
        }
    }
}
