// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SpendingMandateBankTransfer : StripeEntity<SpendingMandateBankTransfer>
    {
        /// <summary>
        /// The name of the account holder that initiated the debit.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// ACH-specific authorization details. Present when <c>network</c> is <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public SpendingMandateBankTransferAch Ach { get; set; }

        /// <summary>
        /// The financial address associated with this mandate.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// The bank transfer network for this mandate.
        /// One of: <c>ach</c>, <c>bacs</c>, or <c>sepa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The mandate reference provided by the bank for Bacs or the creditor's unique mandate
        /// reference (UMR) for SEPA.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
