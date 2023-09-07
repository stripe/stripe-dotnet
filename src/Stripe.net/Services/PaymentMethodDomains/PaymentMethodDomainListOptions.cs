// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodDomainListOptions : ListOptions
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
