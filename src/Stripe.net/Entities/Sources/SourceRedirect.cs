namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceRedirect : StripeEntity<SourceRedirect>
    {
        [JsonProperty("failure_reason")]
        public RedirectFailureReason? FailureReason { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
