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
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("expires")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Expires { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonIgnore]
        public string RawJson => this.StripeResponse?.Content;
    }
}
