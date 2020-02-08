namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OAuthDeauthorizeOptions : BaseOptions
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
