// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// if present, only return the account default or non-default configurations.
        /// </summary>
        [JsonProperty("is_account_default")]
        [STJS.JsonPropertyName("is_account_default")]
        public bool? IsAccountDefault { get; set; }
    }
}
