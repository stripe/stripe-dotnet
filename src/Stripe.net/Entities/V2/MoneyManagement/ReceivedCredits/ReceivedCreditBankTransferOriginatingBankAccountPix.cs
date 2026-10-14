// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferOriginatingBankAccountPix : StripeEntity<ReceivedCreditBankTransferOriginatingBankAccountPix>
    {
        /// <summary>
        /// The name of the account holder that sent the payment.
        /// </summary>
        [JsonProperty("account_holder_name")]
        [STJS.JsonPropertyName("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The bank name the transfer was received from.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The Pix BR code of the account that originated the transfer.
        /// </summary>
        [JsonProperty("br_code")]
        [STJS.JsonPropertyName("br_code")]
        public string BrCode { get; set; }

        /// <summary>
        /// Open Enum. The money transmission network used to send funds for this ReceivedCredit.
        /// One of: <c>pix</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
