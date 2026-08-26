// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateAccountDetailsDataOptions : INestedOptions
    {
        /// <summary>
        /// Default account settings.
        /// </summary>
        [JsonProperty("defaults")]
        [STJS.JsonPropertyName("defaults")]
        public AccountActivityCreateAccountDetailsDataDefaultsOptions Defaults { get; set; }
    }
}
