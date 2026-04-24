// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BatchJobCreateEndpointOptions : INestedOptions
    {
        /// <summary>
        /// The HTTP method to use when calling the endpoint.
        /// One of: <c>delete</c>, or <c>post</c>.
        /// </summary>
        [JsonProperty("http_method")]
        [STJS.JsonPropertyName("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The path of the endpoint to run this batch job against. In the form used in the
        /// documentation. For instance, for subscription migration this would be
        /// <c>/v1/subscriptions/:id/migrate</c>.
        /// One of: <c>/v1/accounts/:account</c>, <c>/v1/credit_notes</c>,
        /// <c>/v1/customers/:customer</c>, <c>/v1/invoices/:invoice</c>,
        /// <c>/v1/invoices/:invoice/pay</c>, <c>/v1/promotion_codes</c>,
        /// <c>/v1/promotion_codes/:promotion_code</c>,
        /// <c>/v1/subscriptions/:subscription_exposed_id</c>,
        /// <c>/v1/subscriptions/:subscription/migrate</c>, <c>/v1/subscription_schedules</c>,
        /// <c>/v1/subscription_schedules/:schedule</c>, or
        /// <c>/v1/subscription_schedules/:schedule/cancel</c>.
        /// </summary>
        [JsonProperty("path")]
        [STJS.JsonPropertyName("path")]
        public BatchJobEndpointPath Path { get; set; }
    }
}
