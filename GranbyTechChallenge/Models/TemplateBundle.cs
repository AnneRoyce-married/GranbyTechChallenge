namespace GranbyTechChallenge.Models
{
 /// <summary>
/// Represents a predefined packing template or kit consisting of one or more stock items.
/// </summary>
    public class TemplateBundle
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<TemplateBundleDetail> BundleItems { get; set; }
            = new List<TemplateBundleDetail>();

        public ICollection<Order> Orders { get; set; }
            = new List<Order>();
    }
}
