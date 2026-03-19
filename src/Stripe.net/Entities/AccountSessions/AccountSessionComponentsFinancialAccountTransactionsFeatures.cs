// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsFinancialAccountTransactionsFeatures : StripeEntity<AccountSessionComponentsFinancialAccountTransactionsFeatures>
    {
        /// <summary>
        /// Whether to allow card spend dispute management features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
        [STJS.JsonPropertyName("card_spend_dispute_management")]
        public bool CardSpendDisputeManagement { get; set; }
    }
}
