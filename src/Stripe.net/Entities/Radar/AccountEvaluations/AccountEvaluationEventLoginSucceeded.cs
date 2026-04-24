// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEvaluationEventLoginSucceeded : StripeEntity<AccountEvaluationEventLoginSucceeded>
    {
        /// <summary>
        /// The qualification for a login success.
        /// </summary>
        [JsonProperty("qualification")]
        [STJS.JsonPropertyName("qualification")]
        public string Qualification { get; set; }
    }
}
