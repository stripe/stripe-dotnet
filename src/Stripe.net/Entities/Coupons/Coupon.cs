namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Coupon : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount_off")]
        public long? AmountOff { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_in_months")]
        public long? DurationInMonths { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("max_redemptions")]
        public long? MaxRedemptions { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percent_off")]
        public decimal? PercentOff { get; set; }

        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? RedeemBy { get; set; }

        [JsonProperty("times_redeemed")]
        public long TimesRedeemed { get; private set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
