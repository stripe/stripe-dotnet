// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodDomainListOptions : ListOptions
    {
        /// <summary>
        /// The domain name that this payment method domain object represents.
        /// </summary>
        [JsonProperty("domain_name")]
        [STJS.JsonPropertyName("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods will not appear in Elements or Embedded Checkout.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
