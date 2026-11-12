// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Controls how individual line items are displayed on the invoice, visible to customers.
        /// </summary>
        [JsonProperty("line_item_policy")]
        [STJS.JsonPropertyName("line_item_policy")]
        public InvoiceRenderingTemplateLineItemPolicyOptions LineItemPolicy { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Nickname for the template that is hidden from customers.
        /// </summary>
        [JsonProperty("nickname")]
        [STJS.JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Controls the grouping of line items into summary items which are displayed on the
        /// invoice, visible to customers. The policies are applied in order - only ungrouped line
        /// items from the previous policy are considered by the following policies.
        /// </summary>
        [JsonProperty("summary_item_policies")]
        [STJS.JsonPropertyName("summary_item_policies")]
        public List<InvoiceRenderingTemplateSummaryItemPolicyOptions> SummaryItemPolicies { get; set; }
    }
}
