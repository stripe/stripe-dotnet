namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class DisputeCreateOptions : CardholderSharedOptions
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("disputed_transaction")]
        public string DisputedTransactionId { get; set; }

        [FormProperty("evidence")]
        public EvidenceOptions Evidence { get; set; }

        [FormProperty("reason")]
        public string Reason { get; set; }
    }
}
