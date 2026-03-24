// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A descriptive name for the FinancialAccount, up to 50 characters long. This name will be
        /// used in the Stripe Dashboard and embedded components.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Metadata associated with the FinancialAccount.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Parameters specific to creating <c>storage</c> type FinancialAccounts.
        /// </summary>
        [JsonProperty("storage")]
        [STJS.JsonPropertyName("storage")]
        public FinancialAccountCreateStorageOptions Storage { get; set; }

        /// <summary>
        /// The type of FinancialAccount to create.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
