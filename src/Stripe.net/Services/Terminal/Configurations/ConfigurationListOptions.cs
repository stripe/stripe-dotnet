// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// if present, only return the account default or non-default configurations.
        /// </summary>
        [JsonProperty("is_account_default")]
        public bool? IsAccountDefault { get; set; }
    }
}
