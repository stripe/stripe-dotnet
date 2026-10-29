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
        /// One of: <c>bank_account</c>, or <c>card</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
