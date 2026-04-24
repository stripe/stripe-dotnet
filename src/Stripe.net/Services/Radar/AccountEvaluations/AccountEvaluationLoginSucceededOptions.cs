// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationLoginSucceededOptions : INestedOptions
    {
        /// <summary>
        /// An optional qualification for a login success.
        /// </summary>
        [JsonProperty("qualification")]
        [STJS.JsonPropertyName("qualification")]
        public string Qualification { get; set; }
    }
}
