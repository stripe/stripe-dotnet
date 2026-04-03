// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerEvaluationEvaluationContextCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The ID of an existing Customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Customer data.
        /// </summary>
        [JsonProperty("customer_data")]
        [STJS.JsonPropertyName("customer_data")]
        public CustomerEvaluationEvaluationContextCustomerDetailsCustomerDataOptions CustomerData { get; set; }
    }
}
