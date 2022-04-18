// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationListOptions : ListOptions
    {
        [JsonProperty("is_account_default")]
        public bool? IsAccountDefault { get; set; }
    }
}
