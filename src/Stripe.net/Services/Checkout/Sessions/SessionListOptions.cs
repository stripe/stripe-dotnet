namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionListOptions : ListOptions
    {
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
