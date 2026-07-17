using GranbyTechChallenge.Models;

namespace GranbyTechChallenge.Services
{
    public class FulfilmentService
    {
     
        public bool CanFulfilOrder(
        Order order,
        TemplateBundle template,
        List<StockItem> stock)
        {
            foreach (var item in template.BundleItems)
            {
                var stockItem = stock.Single(s => s.Id == item.StockItemId);

                var required = item.QuantityRequired * order.Quantity;

                if (stockItem.QuantityAvailable < required)
                    return false;
            }

            return true;
        }

    }






}
