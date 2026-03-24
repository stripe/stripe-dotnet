// File generated from our OpenAPI spec
namespace Stripe.Forwarding
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestListOptions : ListOptions
    {
        /// <summary>
        /// Similar to other List endpoints, filters results based on created timestamp. You can
        /// pass gt, gte, lt, and lte timestamp values.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public RequestCreatedOptions Created { get; set; }
    }
}
