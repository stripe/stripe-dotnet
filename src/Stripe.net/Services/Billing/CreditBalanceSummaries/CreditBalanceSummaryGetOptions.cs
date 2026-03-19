// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditBalanceSummaryGetOptions : BaseOptions
    {
        /// <summary>
        /// The customer whose credit balance summary you're retrieving.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The account representing the customer whose credit balance summary you're retrieving.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The filter criteria for the credit balance summary.
        /// </summary>
        [JsonProperty("filter")]
        [STJS.JsonPropertyName("filter")]
        public CreditBalanceSummaryFilterOptions Filter { get; set; }
    }
}
