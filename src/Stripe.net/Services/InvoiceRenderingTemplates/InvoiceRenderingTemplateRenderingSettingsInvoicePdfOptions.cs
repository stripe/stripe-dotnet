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
        /// Ordered invoice PDF blocks. A maximum of 20 blocks is allowed.
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
