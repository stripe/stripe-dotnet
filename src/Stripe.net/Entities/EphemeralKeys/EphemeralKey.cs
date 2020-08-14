namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class EphemeralKey : StripeEntity<EphemeralKey>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("associated_objects")]
        public List<EphemeralKeyAssociatedObject> AssociatedObjects { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Time at which the key will expire. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Expires { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
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
