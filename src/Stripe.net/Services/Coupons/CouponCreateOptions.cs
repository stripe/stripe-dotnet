namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CouponCreateOptions : BaseOptions, IHasId, IHasMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_off")]
        public long? AmountOff { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("percent_off")]
        public decimal? PercentOff { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_in_months")]
        public long? DurationInMonths { get; set; }

        [JsonProperty("max_redemptions")]
        public long? MaxRedemptions { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? RedeemBy { get; set; }
    }
}
