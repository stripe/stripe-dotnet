namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentPaymentMethodOptionsCard : StripeEntity<SetupIntentPaymentMethodOptionsCard>
    {
        [JsonProperty("request_three_d_secure")]
        public string RequestThreeDSecure { get; set; }
    }
}
