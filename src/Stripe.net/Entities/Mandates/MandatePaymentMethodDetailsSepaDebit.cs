namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandatePaymentMethodDetailsSepaDebit : StripeEntity<MandatePaymentMethodDetailsSepaDebit>
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
