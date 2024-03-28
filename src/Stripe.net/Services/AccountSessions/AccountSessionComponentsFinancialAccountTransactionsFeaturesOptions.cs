// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsFinancialAccountTransactionsFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether to allow card spend dispute features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
        public bool? CardSpendDisputeManagement { get; set; }
    }
}
