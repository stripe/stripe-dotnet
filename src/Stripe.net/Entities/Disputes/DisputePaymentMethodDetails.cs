// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputePaymentMethodDetails : StripeEntity<DisputePaymentMethodDetails>
    {
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public DisputePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public DisputePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public DisputePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public DisputePaymentMethodDetailsPaypal Paypal { get; set; }

        /// <summary>
        /// Payment method type.
        /// One of: <c>amazon_pay</c>, <c>card</c>, <c>klarna</c>, or <c>paypal</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
