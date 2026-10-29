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
        /// Filter for Adjustments linked to a specific flow object. This filter only supports
        /// filtering by the flow object's ID, such as <c>ibt_123</c> for an InboundTransfer.
        /// </summary>
        [JsonProperty("adjusted_flow")]
        [STJS.JsonPropertyName("adjusted_flow")]
        public string AdjustedFlow { get; set; }

        /// <summary>
        /// Filter for Adjustments by their creation time using <c>gt</c>, <c>gte</c>, <c>lt</c>, or
        /// <c>lte</c>.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public AdjustmentListCreatedOptions Created { get; set; }
    }
}
