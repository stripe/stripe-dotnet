namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCardThreeDSecureUsage : StripeEntity<PaymentMethodCardThreeDSecureUsage>
    {
        [JsonProperty("supported")]
        public bool? Supported { get; set; }
    }
}
