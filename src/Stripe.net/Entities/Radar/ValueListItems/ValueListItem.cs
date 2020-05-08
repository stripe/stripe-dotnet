namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueListItem : StripeEntity<ValueListItem>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("deleted", NullValueHandling=NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
