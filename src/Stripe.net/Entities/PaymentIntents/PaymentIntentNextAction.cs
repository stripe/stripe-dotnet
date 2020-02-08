namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextAction : StripeEntity<PaymentIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public PaymentIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
