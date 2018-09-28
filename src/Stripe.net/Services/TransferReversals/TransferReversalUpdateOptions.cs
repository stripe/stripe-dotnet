namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class TransferReversalUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
