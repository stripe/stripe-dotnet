// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentTrackingDetails : StripeEntity<OutboundPaymentTrackingDetails>
    {
        /// <summary>
        /// Bank account tracking details.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public OutboundPaymentTrackingDetailsBankAccount BankAccount { get; set; }

        /// <summary>
        /// Card tracking details.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OutboundPaymentTrackingDetailsCard Card { get; set; }

        /// <summary>
        /// Crypto wallet tracking details.
        /// </summary>
        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public OutboundPaymentTrackingDetailsCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// Paper check tracking details.
        /// </summary>
        [JsonProperty("paper_check")]
        [STJS.JsonPropertyName("paper_check")]
        public OutboundPaymentTrackingDetailsPaperCheck PaperCheck { get; set; }

        /// <summary>
        /// The status of the tracking details for this OutboundPayment.
        /// One of: <c>pending</c>, <c>supported</c>, or <c>unsupported</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of tracking details for this OutboundPayment.
        /// One of: <c>bank_account</c>, <c>card</c>, <c>check_send</c>, <c>crypto_wallet</c>, or
        /// <c>paper_check</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
