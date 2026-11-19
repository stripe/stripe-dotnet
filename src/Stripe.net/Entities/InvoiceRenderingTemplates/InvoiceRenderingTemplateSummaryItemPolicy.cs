// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateSummaryItemPolicy : StripeEntity<InvoiceRenderingTemplateSummaryItemPolicy>
    {
        /// <summary>
        /// Either <c>all</c> or <c>none</c>. For all summary items created from this policy, if
        /// <c>all</c>, every line item will be shown under the summary item header. If <c>none</c>,
        /// the line items will be hidden and only the summary item header will be shown.
        /// </summary>
        [JsonProperty("display_items")]
        [STJS.JsonPropertyName("display_items")]
        public string DisplayItems { get; set; }

        /// <summary>
        /// A CEL expression that takes in a line item and returns a boolean indicating whether the
        /// line item should be considered when grouping.
        /// </summary>
        [JsonProperty("filter")]
        [STJS.JsonPropertyName("filter")]
        public string Filter { get; set; }

        /// <summary>
        /// A CEL expression that takes in a line item and returns a string. Line items with the
        /// same string results are put in the same summary items. The string result will become the
        /// description of the summary item.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public string GroupBy { get; set; }
    }
}
