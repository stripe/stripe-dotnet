namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountLink : StripeEntity<AccountLink>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
