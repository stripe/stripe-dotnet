namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodIdeal : StripeEntity<PaymentMethodIdeal>
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }
    }
}
