// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferEuBankTransfer>
    {
        /// <summary>
        /// The BIC of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif
        public string Bic { get; set; }

        /// <summary>
        /// The last 4 digits of the IBAN of the sender of the funding.
        /// </summary>
        [JsonProperty("iban_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban_last4")]
#endif
        public string IbanLast4 { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sender_name")]
#endif
        public string SenderName { get; set; }
    }
}
