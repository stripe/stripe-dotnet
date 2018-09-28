namespace Stripe
{
    using Stripe.Infrastructure;

    public class BalanceTransactionListOptions : ListOptions
    {
        [FormProperty("available_on")]
        public DateFilter AvailableOn { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("payout")]
        public string PayoutId { get; set; }

        [FormProperty("source")]
        public string SourceId { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}
