namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PlanUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("active")]
        public bool? Active { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("nickname")]
        public string Nickname { get; set; }

        [FormProperty("product")]
        public string ProductId { get; set; }
    }
}
