// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferOriginatingBankAccountNip : StripeEntity<ReceivedCreditBankTransferOriginatingBankAccountNip>
    {
        /// <summary>
        /// The name of the account holder that sent the payment.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The Nigerian bank code of the bank that originated the transfer.
        /// </summary>
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// The name of the bank that originated the transfer.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The last 4 digits of the account number that originated the transfer.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Open Enum. The money transmission network used to send funds for this ReceivedCredit.
        /// One of: <c>nip</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
