// File generated from our OpenAPI spec
namespace Stripe.V2.Payments.SettlementAllocationIntents
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SplitCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The target account for settling the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The amount and currency of the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Metadata associated with the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The type of the fund transfer.
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
