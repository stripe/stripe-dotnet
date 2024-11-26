// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApplePayDomainListOptions : ListOptions
    {
        [JsonProperty("domain_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("domain_name")]
#endif
        public string DomainName { get; set; }
    }
}
