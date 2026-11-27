// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingTemplateRenderingSettingsInvoicePdfOptions : INestedOptions, IHasSetTracking
    {
        private List<InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockOptions> blocks;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The complete replacement order of at most 20 invoice PDF blocks. Keys retain saved
        /// configuration when its hash is omitted. Omitted custom blocks are removed; include every
        /// default type exactly once. Omit blocks to preserve settings, or supply an empty string
        /// to reset to defaults.
        /// </summary>
        [JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("blocks")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<InvoiceRenderingTemplateRenderingSettingsInvoicePdfBlockOptions> Blocks
        {
            get => this.blocks;
            set
            {
                this.blocks = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
