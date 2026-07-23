// File generated from our OpenAPI spec
namespace Stripe.Crypto
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OnrampSessionListOptions : ListOptions
    {
        /// <summary>
        /// Only return onramp sessions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// The destination cryptocurrency to filter by.
        /// One of: <c>avax</c>, <c>btc</c>, <c>eth</c>, <c>matic</c>, <c>sol</c>, <c>usdc</c>,
        /// <c>wld</c>, or <c>xlm</c>.
        /// </summary>
        [JsonProperty("destination_currency")]
        [STJS.JsonPropertyName("destination_currency")]
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// The destination blockchain network to filter by.
        /// One of: <c>avalanche</c>, <c>base</c>, <c>bitcoin</c>, <c>ethereum</c>, <c>optimism</c>,
        /// <c>polygon</c>, <c>solana</c>, <c>stellar</c>, <c>sui</c>, or <c>worldchain</c>.
        /// </summary>
        [JsonProperty("destination_network")]
        [STJS.JsonPropertyName("destination_network")]
        public string DestinationNetwork { get; set; }

        /// <summary>
        /// The status of the Onramp Session. One of = <c>{initialized, rejected, requires_payment,
        /// fulfillment_processing, fulfillment_complete}</c>.
        /// One of: <c>fulfillment_complete</c>, <c>fulfillment_processing</c>, <c>initialized</c>,
        /// <c>rejected</c>, or <c>requires_payment</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
