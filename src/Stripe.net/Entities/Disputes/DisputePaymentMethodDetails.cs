// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetails : StripeEntity<DisputePaymentMethodDetails>
    {
        [JsonProperty("card")]
        public DisputePaymentMethodDetailsCard Card { get; set; }

        [JsonProperty("paypal")]
        public DisputePaymentMethodDetailsPaypal Paypal { get; set; }

        /// <summary>
        /// Payment method type.
        /// One of: <c>card</c>, or <c>paypal</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
