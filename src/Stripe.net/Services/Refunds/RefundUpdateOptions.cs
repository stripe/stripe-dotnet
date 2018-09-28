namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class RefundUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
