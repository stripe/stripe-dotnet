namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class TransferReversalCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }
    }
}
