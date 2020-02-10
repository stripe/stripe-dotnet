namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OAuthDeauthorize : StripeEntity<OAuthDeauthorize>
    {
        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
