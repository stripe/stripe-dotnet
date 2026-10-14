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
        /// The account's contact email.
        /// </summary>
        [JsonProperty("contact_email")]
        [STJS.JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

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
