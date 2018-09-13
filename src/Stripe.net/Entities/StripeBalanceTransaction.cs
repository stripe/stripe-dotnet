namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeBalanceTransaction : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("available_on")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime AvailableOn { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }

        [JsonProperty("fee_details")]
        public List<StripeFee> FeeDetails { get; set; }

        [JsonProperty("net")]
        public int Net { get; set; }

        #region Expandable BalanceTransactionSource
        public string SourceId { get; set; }

        [JsonIgnore]
        public BalanceTransactionSource Source { get; set; }

        [JsonProperty("source")]
        internal object InternalSource
        {
            set
            {
                StringOrObject<BalanceTransactionSource>.Map(value, s => this.SourceId = s, o => this.Source = o);
            }
        }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
