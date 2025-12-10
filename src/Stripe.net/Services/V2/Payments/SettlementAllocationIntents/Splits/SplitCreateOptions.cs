// File generated from our OpenAPI spec
namespace Stripe.V2.Payments.SettlementAllocationIntents
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SplitCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The account to target for this credit/debit.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The amount and currency of the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public SplitCreateAmountOptions Amount { get; set; }

        /// <summary>
        /// Metadata associated with the SettlementAllocationIntentSplit.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The type of the fund transfer.
        /// One of: <c>credit</c>, or <c>debit</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
