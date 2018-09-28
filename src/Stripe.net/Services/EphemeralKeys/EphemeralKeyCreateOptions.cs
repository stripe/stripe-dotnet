namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("-")]
        public string StripeVersion { get; set; }
    }
}
