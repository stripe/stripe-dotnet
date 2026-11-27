// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SpendingMandateBankTransferAch : StripeEntity<SpendingMandateBankTransferAch>
    {
        /// <summary>
        /// ACH Company ID used to identify the authorized originator.
        /// </summary>
        [JsonProperty("originator_company_id")]
        [STJS.JsonPropertyName("originator_company_id")]
        public string OriginatorCompanyId { get; set; }

        /// <summary>
        /// Maximum amount authorized for a single debit. If absent, the Financial Account limit
        /// applies.
        /// </summary>
        [JsonProperty("transaction_limit")]
        [STJS.JsonPropertyName("transaction_limit")]
        public V2.Amount TransactionLimit { get; set; }
    }
}
