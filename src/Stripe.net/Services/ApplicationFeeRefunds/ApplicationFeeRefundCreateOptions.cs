namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ApplicationFeeRefundCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
