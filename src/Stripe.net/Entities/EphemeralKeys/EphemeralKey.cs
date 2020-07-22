namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EphemeralKey : StripeEntity<EphemeralKey>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("associated_objects")]
        public List<EphemeralKeyAssociatedObject> AssociatedObjects { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("expires")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Expires { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// <see cref="RawJson"/> is the raw JSON data of the response that was used to initialize
        /// this ephemeral key. When working with mobile clients that might only understand
        /// one version of the API you should prefer to send this value back to them so
        /// that they'll be able to decode an object that's current according to their version.
        /// </summary>
        [JsonIgnore]
        public string RawJson => this.StripeResponse?.Content;
    }
}
