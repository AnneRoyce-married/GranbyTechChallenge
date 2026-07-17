namespace GranbyTechChallenge.Models.Results
{/// <summary>
/// Represents the outcome of processing a batch of orders.
/// </summary>
    public class FulfilmentResult
    {
        public List<Order> FulfilledOrders { get; } = [];

        public List<Order> UnfulfilledOrders { get; } = [];

        public Dictionary<int, int> StockShortfalls { get; } = [];
    }
}
