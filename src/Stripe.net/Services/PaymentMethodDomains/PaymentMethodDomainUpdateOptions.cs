// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodDomainUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements or Embedded
        /// Checkout.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
