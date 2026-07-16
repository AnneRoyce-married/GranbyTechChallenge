namespace GranbyTechChallenge.Models
{
    /// <summary>
    /// Represents the stock items and quantities required to build a specific template bundle.
    /// </summary>
    public class TemplateBundleDetail
    {
        public int Id { get; set; }

        public int TemplateBundleId { get; set; }

        public TemplateBundle? TemplateBundle { get; set; }

        public int StockItemId { get; set; }

        public StockItem? StockItem { get; set; }

        public int QuantityRequired { get; set; }
    }
}
