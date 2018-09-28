namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CouponUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }
    }
}
