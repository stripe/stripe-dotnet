// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountDetailsDataDefaultsOptions : INestedOptions
    {
        /// <summary>
        /// Account profile data.
        /// </summary>
        [JsonProperty("profile")]
        [STJS.JsonPropertyName("profile")]
        public AccountEvaluationCreateAccountDetailsDataDefaultsProfileOptions Profile { get; set; }
    }
}
