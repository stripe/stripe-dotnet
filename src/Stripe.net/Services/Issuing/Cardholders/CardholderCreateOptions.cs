namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardholderCreateOptions : CardholderSharedOptions
    {
        [FormProperty("type")]
        public string Type { get; set; }
    }
}
