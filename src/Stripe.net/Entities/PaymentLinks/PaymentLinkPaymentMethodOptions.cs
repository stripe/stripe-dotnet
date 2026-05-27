// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkPaymentMethodOptions : StripeEntity<PaymentLinkPaymentMethodOptions>
    {
        /// <summary>
        /// Configuration for <c>card</c> payment methods.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentLinkPaymentMethodOptionsCard Card { get; set; }
    }
}
