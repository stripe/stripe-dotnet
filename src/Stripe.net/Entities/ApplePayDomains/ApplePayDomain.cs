namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplePayDomain : StripeEntity, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("domain_name")]
        public string DomainName { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
