// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Metadata associated with the FinancialAccount.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Parameters specific to creating <c>storage</c> type FinancialAccounts.
        /// </summary>
        [JsonProperty("storage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("storage")]
#endif
        public FinancialAccountCreateStorageOptions Storage { get; set; }

        /// <summary>
        /// The type of FinancialAccount to create.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
