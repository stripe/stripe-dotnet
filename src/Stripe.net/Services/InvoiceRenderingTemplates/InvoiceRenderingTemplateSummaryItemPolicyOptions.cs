// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateSummaryItemPolicyOptions : INestedOptions
    {
        /// <summary>
        /// Controls how each summary group is rendered on the invoice. <c>all</c> displays the
        /// summary line item, its constituent line items, and a group subtotal. <c>none</c>
        /// displays only the summary line item. Defaults to <c>all</c>.
        /// One of: <c>all</c>, or <c>none</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("display_items")]
        [STJS.JsonPropertyName("display_items")]
        public string DisplayItems { get; set; }

        /// <summary>
        /// A CEL expression that takes a line item and returns a boolean indicating whether to
        /// include it in this grouping policy. If omitted, includes all ungrouped line items.
        /// </summary>
        [JsonProperty("filter")]
        [STJS.JsonPropertyName("filter")]
        public string Filter { get; set; }

        /// <summary>
        /// A CEL expression that takes a line item and returns a string. Line items with the same
        /// result are grouped into a summary item, using that result as its group title.
        /// </summary>
        [JsonProperty("group_by")]
        [STJS.JsonPropertyName("group_by")]
        public string GroupBy { get; set; }
    }
}
