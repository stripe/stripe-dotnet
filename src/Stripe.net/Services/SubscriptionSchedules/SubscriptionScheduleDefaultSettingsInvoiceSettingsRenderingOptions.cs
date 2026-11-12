// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleDefaultSettingsInvoiceSettingsRenderingOptions : INestedOptions, IHasSetTracking
    {
        private long? templateVersion;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// ID of the invoice rendering template to use for future invoices.
        /// </summary>
        [JsonProperty("template")]
        [STJS.JsonPropertyName("template")]
        public string Template { get; set; }

        /// <summary>
        /// The specific version of invoice rendering template to use for future invoices. If set to
        /// null, the latest version of the template will be used.
        /// </summary>
        [JsonProperty("template_version", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("template_version")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? TemplateVersion
        {
            get => this.templateVersion;
            set
            {
                this.templateVersion = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
