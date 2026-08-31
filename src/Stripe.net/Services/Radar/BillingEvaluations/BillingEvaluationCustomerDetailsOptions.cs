// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BillingEvaluationCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the customer whose upcoming payment is being evaluated.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Account representing the customer whose upcoming payment is being
        /// evaluated.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Attributes of the customer being evaluated. Supply these when the customer isn't
        /// represented by a Customer or an Account. If <c>customer</c> or <c>customer_account</c>
        /// is also supplied, the attributes on that object are used and these are ignored.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public BillingEvaluationCustomerDetailsDataOptions Data { get; set; }
    }
}
