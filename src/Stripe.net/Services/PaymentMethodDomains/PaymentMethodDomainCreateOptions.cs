// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainCreateOptions : BaseOptions
    {
        /// <summary>
        /// The domain name that this payment method domain object represents.
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this payment method domain is enabled. If the domain is not enabled, payment
        /// methods that require a payment method domain will not appear in Elements.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
