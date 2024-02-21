using Balta.ContentContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Base
    {
        public string? Title { get; set; }
        public decimal price { get; set; }
    }
}