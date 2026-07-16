namespace GranbyTechChallenge.Models
{
    /// <summary>
    /// Represents a stock item held in inventory that can be allocated to one or more template bundles.
    /// </summary>
    public class StockItem
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public int QuantityOnHand { get; set; }

        public int QuantityAllocated { get; set; }

        public int QuantityAvailable => QuantityOnHand - QuantityAllocated;

        public string Unit { get; set; } = string.Empty;

        public ICollection<TemplateBundleDetail> TemplateBundleDetails { get; set; }
            = new List<TemplateBundleDetail>();
    }
}
