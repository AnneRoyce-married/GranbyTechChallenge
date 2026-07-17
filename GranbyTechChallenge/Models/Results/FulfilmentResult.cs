namespace GranbyTechChallenge.Models.Results
{
    public class FulfilmentResult
    {
        public List<Order> FulfilledOrders { get; } = [];

        public List<Order> UnfulfilledOrders { get; } = [];

        public Dictionary<int, int> StockShortfalls { get; } = [];
    }
}
