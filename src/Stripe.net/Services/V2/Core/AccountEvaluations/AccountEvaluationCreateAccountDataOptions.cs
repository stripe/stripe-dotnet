// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountDataOptions : INestedOptions
    {
        /// <summary>
        /// Default account settings.
        /// </summary>
        [JsonProperty("defaults")]
        [STJS.JsonPropertyName("defaults")]
        public AccountEvaluationCreateAccountDataDefaultsOptions Defaults { get; set; }

        /// <summary>
        /// Identity data.
        /// </summary>
        [JsonProperty("identity")]
        [STJS.JsonPropertyName("identity")]
        public AccountEvaluationCreateAccountDataIdentityOptions Identity { get; set; }
    }
}
