// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsFinancialAccountTransactionsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow card spend dispute management features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_spend_dispute_management")]
#endif
        public bool? CardSpendDisputeManagement { get; set; }
    }
}
