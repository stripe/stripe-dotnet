// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApplePayDomainCreateOptions : BaseOptions
    {
        [JsonProperty("domain_name")]
        [STJS.JsonPropertyName("domain_name")]
        public string DomainName { get; set; }
    }
}
