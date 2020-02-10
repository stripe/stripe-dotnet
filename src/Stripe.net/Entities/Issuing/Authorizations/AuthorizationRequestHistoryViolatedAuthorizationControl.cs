namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistoryViolatedAuthorizationControl : StripeEntity<AuthorizationRequestHistoryViolatedAuthorizationControl>
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
