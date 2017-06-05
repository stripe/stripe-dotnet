using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeBalanceTransaction : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("available_on")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime AvailableOn { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("fee_details")]
        public List<StripeFee> FeeDetails { get; set; }

        [JsonProperty("net")]
        public int Net { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Source
        public string SourceId { get; set; }

        [JsonIgnore]
        public StripeSource Source { get; set; }

        [JsonProperty("source")]
        internal object InternalSource
        {
            set
            {
                StringOrObject<StripeSource>.Map(value, s => SourceId = s, o => Source = o);
            }
        }
        #endregion
    }
}
