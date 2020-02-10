namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class RefundListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
