namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardSharedOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("billing")]
        public BillingOptions Billing { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }
    }
}
