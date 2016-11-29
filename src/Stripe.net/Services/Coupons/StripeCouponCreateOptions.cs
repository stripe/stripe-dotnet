using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCouponCreateOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_off")]
        public int? AmountOff { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("percent_off")]
        public int? PercentOff { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("duration_in_months")]
        public int? DurationInMonths { get; set; }

        [JsonProperty("max_redemptions")]
        public int? MaxRedemptions { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        public DateTime? RedeemBy { get; set; }

        [JsonProperty("redeem_by")]
        internal long? RedeemByInternal
        {
            get
            {
                if (!RedeemBy.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(RedeemBy.Value);
            }
        }
    }
}
