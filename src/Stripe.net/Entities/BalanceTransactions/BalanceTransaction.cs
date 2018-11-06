namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BalanceTransaction : StripeEntity, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

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
        public long Fee { get; set; }

        [JsonProperty("fee_details")]
        public List<Fee> FeeDetails { get; set; }

        [JsonProperty("net")]
        public long Net { get; set; }

        #region Expandable Source
        public string SourceId => this.InternalSource.Id;

        [JsonIgnore]
        public IBalanceTransactionSource Source => this.InternalSource.ExpandedObject;

        [JsonProperty("source")]
        internal ExpandableField<IBalanceTransactionSource> InternalSource { get; set; }
        #endregion

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
