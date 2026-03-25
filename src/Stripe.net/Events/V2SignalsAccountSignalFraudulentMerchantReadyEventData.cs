// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2SignalsAccountSignalFraudulentMerchantReadyEventData : StripeEntity<V2SignalsAccountSignalFraudulentMerchantReadyEventData>,
        IHasId
    {
        /// <summary>
        /// Account ID that this signal is associated with.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Timestamp when the signal was evaluated.
        /// </summary>
        [JsonProperty("evaluated_at")]
        [STJS.JsonPropertyName("evaluated_at")]
        public DateTime EvaluatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Fraudulent merchant signal data. Present when type is fraudulent_merchant.
        /// </summary>
        [JsonProperty("fraudulent_merchant")]
        [STJS.JsonPropertyName("fraudulent_merchant")]
        public V2SignalsAccountSignalFraudulentMerchantReadyEventDataFraudulentMerchant FraudulentMerchant { get; set; }

        /// <summary>
        /// Unique identifier for this account signal.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of account signal. Currently only fraudulent_merchant is supported.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
