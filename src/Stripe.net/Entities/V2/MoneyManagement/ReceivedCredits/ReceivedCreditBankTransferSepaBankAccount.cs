// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferSepaBankAccount : StripeEntity<ReceivedCreditBankTransferSepaBankAccount>
    {
        /// <summary>
        /// The account holder name of the bank account the transfer was received from.
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
        /// The BIC of the SEPA account.
        /// </summary>
        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// The origination country of the bank transfer.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The IBAN that originated the transfer.
        /// </summary>
        [JsonProperty("iban")]
        [STJS.JsonPropertyName("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// The money transmission network used to send funds for this ReceivedCredit.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
