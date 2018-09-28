namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class TransferUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
