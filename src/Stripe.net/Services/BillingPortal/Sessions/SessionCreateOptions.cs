namespace Stripe.BillingPortal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
