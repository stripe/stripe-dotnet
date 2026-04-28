// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditCryptoWalletTransfer : StripeEntity<ReceivedCreditCryptoWalletTransfer>
    {
        /// <summary>
        /// Hash containing the transaction crypto wallet details.
        /// </summary>
        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public ReceivedCreditCryptoWalletTransferCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// Financial Address on which funds for ReceivedCredit were received.
        /// </summary>
        [JsonProperty("financial_address")]
        [STJS.JsonPropertyName("financial_address")]
        public string FinancialAddress { get; set; }

        /// <summary>
        /// Open Enum. Indicates the origin of source from which external funds originated from.
        /// One of: <c>ca_bank_account</c>, <c>crypto_wallet</c>, <c>eu_bank_account</c>,
        /// <c>gb_bank_account</c>, <c>mx_bank_account</c>, <c>sepa_bank_account</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("origin_type")]
        [STJS.JsonPropertyName("origin_type")]
        public string OriginType { get; set; }

        /// <summary>
        /// Freeform string set by originator of the external ReceivedCredit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
