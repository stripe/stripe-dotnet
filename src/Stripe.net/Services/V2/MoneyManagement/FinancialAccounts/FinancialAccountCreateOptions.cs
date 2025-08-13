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
        /// A descriptive name for the FinancialAccount, up to 50 characters long. This name will be
        /// used in the Stripe Dashboard and embedded components.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

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
