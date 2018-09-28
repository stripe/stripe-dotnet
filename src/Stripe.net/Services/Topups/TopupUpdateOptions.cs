namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class TopupUpdateOptions : BaseOptions
    {
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
