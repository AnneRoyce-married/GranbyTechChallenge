using GranbyTechChallenge.Models;

namespace GranbyTechChallenge.Interfaces
{
    public interface IOrderFulfilmentStrategy
    {
        Models.Results.FulfilmentResult Process(
        IEnumerable<Order> orders,
        IList<StockItem> stockItems);
    }
}
