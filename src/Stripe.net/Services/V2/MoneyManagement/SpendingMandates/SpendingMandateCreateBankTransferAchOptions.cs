// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SpendingMandateCreateBankTransferAchOptions : INestedOptions
    {
        /// <summary>
        /// ACH Company ID identifying the authorized originator. Must contain exactly 10
        /// alphanumeric characters.
        /// </summary>
        [JsonProperty("originator_company_id")]
        [STJS.JsonPropertyName("originator_company_id")]
        public string OriginatorCompanyId { get; set; }

        /// <summary>
        /// Positive per-debit limit in USD.
        /// </summary>
        [JsonProperty("transaction_limit")]
        [STJS.JsonPropertyName("transaction_limit")]
        public V2.Amount TransactionLimit { get; set; }
    }
}
