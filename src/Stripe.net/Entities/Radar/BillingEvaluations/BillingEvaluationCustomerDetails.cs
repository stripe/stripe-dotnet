// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BillingEvaluationCustomerDetails : StripeEntity<BillingEvaluationCustomerDetails>
    {
        /// <summary>
        /// The ID of the customer whose upcoming payment was evaluated.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Account representing the customer whose upcoming payment was evaluated.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Attributes of the customer being evaluated, as supplied on the request. Null when the
        /// customer was identified by <c>customer</c> or <c>customer_account</c>.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public BillingEvaluationCustomerDetailsData Data { get; set; }
    }
}
