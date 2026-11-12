// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateUpdateOptions : BaseOptions, IHasMetadata
    {
        private InvoiceRenderingTemplateLineItemPolicyOptions lineItemPolicy;
        private Dictionary<string, string> metadata;
        private List<InvoiceRenderingTemplateSummaryItemPolicyOptions> summaryItemPolicies;

        /// <summary>
        /// Controls how individual line items are displayed on the invoice, visible to customers.
        /// </summary>
        [JsonProperty("line_item_policy", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("line_item_policy")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoiceRenderingTemplateLineItemPolicyOptions LineItemPolicy
        {
            get => this.lineItemPolicy;
            set
            {
                this.lineItemPolicy = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

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
        [JsonProperty("summary_item_policies", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("summary_item_policies")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceRenderingTemplateSummaryItemPolicyOptions> SummaryItemPolicies
        {
            get => this.summaryItemPolicies;
            set
            {
                this.summaryItemPolicies = value;
                this.SetTracker.Track();
            }
        }
    }
}
