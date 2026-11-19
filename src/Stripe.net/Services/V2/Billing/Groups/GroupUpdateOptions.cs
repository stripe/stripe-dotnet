// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupUpdateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Billing setting overrides to update. Set to null to restore all applicable defaults.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public GroupUpdateBillingSettingsOptions BillingSettings { get; set; }

        /// <summary>
        /// The ID of the default PaymentMethod object. Set to null to use the customer's default
        /// payment method.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>billing_settings</c>, or <c>invoice_discount_rules</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// An internal key you can use to find a particular billing group. Set to null to clear it.
        /// Maximum length of 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of key-value pairs to add, update, or remove.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJNullPreservingDictionaryConverter))]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }
    }
}
