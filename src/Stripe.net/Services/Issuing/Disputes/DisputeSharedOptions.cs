namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class DisputeSharedOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
