namespace Stripe.Issuing
{
    using Stripe.Infrastructure;

    public class CardListOptions : ListOptions
    {
        [FormProperty("cardholder")]
        public string CardholderId { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("exp_month")]
        public int? ExpMonth { get; set; }

        [FormProperty("exp_year")]
        public int? ExpYear { get; set; }

        [FormProperty("last4")]
        public string Last4 { get; set; }

        [FormProperty("source")]
        public string SourceId { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}
