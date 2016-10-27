using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCoupon : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("amount_off")]
        public int? AmountOff { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("duration_in_months")]
        public int? DurationInMonths { get; set; }

        [JsonProperty("max_redemptions")]
        public int? MaxRedemptions { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("percent_off")]
        public int? PercentOff { get; set; }

        [JsonProperty("redeem_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? RedeemBy { get; set; }

        [JsonProperty("times_redeemed")]
        public int TimesRedeemed { get; private set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
