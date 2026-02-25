// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobCreateOptions : BaseOptions
    {
        /// <summary>
        /// The API endpoint to batch (e.g., /v1/customers/:id for batch customer updates).
        /// One of: <c>/v1/subscription_schedules</c>, <c>/v1/customers/:customer</c>, or
        /// <c>/v1/subscriptions/:subscription_exposed_id</c>.
        /// </summary>
        [JsonProperty("endpoint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("endpoint")]
#endif
        public string Endpoint { get; set; }
    }
}
