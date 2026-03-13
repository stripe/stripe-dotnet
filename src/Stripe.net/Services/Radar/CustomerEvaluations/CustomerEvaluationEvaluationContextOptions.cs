// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerEvaluationEvaluationContextOptions : INestedOptions
    {
        /// <summary>
        /// Client details context.
        /// </summary>
        [JsonProperty("client_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_details")]
#endif
        public CustomerEvaluationEvaluationContextClientDetailsOptions ClientDetails { get; set; }

        /// <summary>
        /// Customer details context.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public CustomerEvaluationEvaluationContextCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The type of context entry.
        /// One of: <c>client_details</c>, or <c>customer_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
