// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerEvaluationEvaluationContextOptions : INestedOptions
    {
        /// <summary>
        /// Client details context.
        /// </summary>
        [JsonProperty("client_details")]
        [STJS.JsonPropertyName("client_details")]
        public CustomerEvaluationEvaluationContextClientDetailsOptions ClientDetails { get; set; }

        /// <summary>
        /// Customer details context.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public CustomerEvaluationEvaluationContextCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// The type of context entry.
        /// One of: <c>client_details</c>, or <c>customer_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
