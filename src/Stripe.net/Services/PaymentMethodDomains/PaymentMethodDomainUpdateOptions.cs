// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
