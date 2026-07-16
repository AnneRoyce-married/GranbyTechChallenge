using GranbyTechChallenge.Models.Enums;

namespace GranbyTechChallenge.Models
{
    /// <summary>
    /// Represents the fulfilment process for an order, tracking its packing status and processing timestamps.
    /// </summary>
    public class PackingJob
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order? Order { get; set; }

        public PackingJobStatus Status { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? CompletedAt { get; set; }
    }
}
