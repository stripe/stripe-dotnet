// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputePaymentMethodDetails : StripeEntity<DisputePaymentMethodDetails>
    {
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif

        public DisputePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public DisputePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif

        public DisputePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif

        public DisputePaymentMethodDetailsPaypal Paypal { get; set; }

        /// <summary>
        /// Payment method type.
        /// One of: <c>amazon_pay</c>, <c>card</c>, <c>klarna</c>, or <c>paypal</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
