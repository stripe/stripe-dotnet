namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionRedirectToUrl : StripeEntity<PaymentIntentNextActionRedirectToUrl>
    {
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
