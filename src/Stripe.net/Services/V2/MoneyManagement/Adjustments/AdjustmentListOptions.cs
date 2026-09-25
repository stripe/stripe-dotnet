// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AdjustmentListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for Adjustments linked to a Flow.
        /// </summary>
        [JsonProperty("adjusted_flow")]
        [STJS.JsonPropertyName("adjusted_flow")]
        public string AdjustedFlow { get; set; }

        /// <summary>
        /// Set of filters to query Adjustments within a range of <c>created</c> timestamps.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public AdjustmentListCreatedOptions Created { get; set; }
    }
}
