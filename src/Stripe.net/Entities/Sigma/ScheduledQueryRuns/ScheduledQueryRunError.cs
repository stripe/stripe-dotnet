// File generated from our OpenAPI spec
namespace Stripe.Sigma
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ScheduledQueryRunError : StripeEntity<ScheduledQueryRunError>
    {
        /// <summary>
        /// Information about the run failure.
        /// </summary>
        [JsonProperty("message")]
        [STJS.JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
