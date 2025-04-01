// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferTransferHistoryBankDebitReturned : StripeEntity<InboundTransferTransferHistoryBankDebitReturned>
    {
        /// <summary>
        /// Open Enum. The return reason for the returned InboundTransfer.
        /// One of: <c>bank_account_closed</c>, <c>bank_account_not_found</c>,
        /// <c>bank_debit_could_not_be_processed</c>, <c>bank_debit_not_authorized</c>, or
        /// <c>insufficient_funds</c>.
        /// </summary>
        [JsonProperty("return_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("return_reason")]
#endif
        public string ReturnReason { get; set; }
    }
}
