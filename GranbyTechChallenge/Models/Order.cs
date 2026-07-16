using GranbyTechChallenge.Models.Enums;

namespace GranbyTechChallenge.Models
{
    /// <summary>
    /// Represents a customer order for one or more quantities of a template bundle, including fulfilment and dispatch information.
    /// </summary>
    public class Order
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; } = string.Empty;

        public int TemplateBundleId { get; set; }

        public TemplateBundle? TemplateBundle { get; set; }

        /// <summary>
        /// Number of bundles ordered.
        /// </summary>
        public int Quantity { get; set; }

        public DateTime ReceivedDate { get; set; }

        public DateTime DispatchDeadline { get; set; }

        public OrderStatus Status { get; set; }

        public PackingJob? PackingJob { get; set; }
    }
}
