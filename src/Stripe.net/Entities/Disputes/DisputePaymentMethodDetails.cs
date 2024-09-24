// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetails : StripeEntity<DisputePaymentMethodDetails>
    {
        [JsonProperty("amazon_pay")]
        public DisputePaymentMethodDetailsAmazonPay AmazonPay { get; set; }

        [JsonProperty("card")]
        public DisputePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("klarna")]
        public DisputePaymentMethodDetailsKlarna Klarna { get; set; }

        [JsonProperty("paypal")]
        public DisputePaymentMethodDetailsPaypal Paypal { get; set; }

        /// <summary>
        /// Payment method type.
        /// One of: <c>amazon_pay</c>, <c>card</c>, <c>klarna</c>, or <c>paypal</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
