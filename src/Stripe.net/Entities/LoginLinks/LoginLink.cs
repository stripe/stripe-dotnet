namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LoginLink : StripeEntity<LoginLink>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
