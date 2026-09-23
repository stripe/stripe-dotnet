// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer : StripeEntity<CustomerCashBalanceTransactionFundedBankTransferGbBankTransfer>
    {
        /// <summary>
        /// The last 4 digits of the account number of the sender of the funding.
        /// </summary>
        [JsonProperty("account_number_last4")]
        [STJS.JsonPropertyName("account_number_last4")]
        public string AccountNumberLast4 { get; set; }

        /// <summary>
        /// The BIC of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// The last 4 digits of the IBAN of the sender of the funding.
        /// </summary>
        [JsonProperty("iban_last4")]
        [STJS.JsonPropertyName("iban_last4")]
        public string IbanLast4 { get; set; }

        /// <summary>
        /// The banking network used for this funding.
        /// One of: <c>bacs</c>, <c>chaps</c>, <c>fps</c>, or <c>swift</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The full name of the sender, as supplied by the sending bank.
        /// </summary>
        [JsonProperty("sender_name")]
        [STJS.JsonPropertyName("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// The sort code of the bank of the sender of the funding.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
