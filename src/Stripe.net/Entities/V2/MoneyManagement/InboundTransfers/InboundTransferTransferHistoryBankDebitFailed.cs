// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferTransferHistoryBankDebitFailed : StripeEntity<InboundTransferTransferHistoryBankDebitFailed>
    {
        /// <summary>
        /// Open Enum. The return reason for the failed InboundTransfer.
        /// One of: <c>bank_account_closed</c>, <c>bank_account_not_found</c>,
        /// <c>bank_debit_could_not_be_processed</c>, <c>bank_debit_not_authorized</c>, or
        /// <c>insufficient_funds</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }
    }
}
