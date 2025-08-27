// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CollectionSettingUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Either automatic, or send_invoice. When charging automatically, Stripe will attempt to
        /// pay this bill at the end of the period using the payment method attached to the payer
        /// profile. When sending an invoice, Stripe will email your payer profile an invoice with
        /// payment instructions.
        /// One of: <c>automatic</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif
        public string CollectionMethod { get; set; }

        /// <summary>
        /// An optional customer-facing display name for the CollectionSetting object. To remove the
        /// display name, set it to an empty string in the request. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        [JsonProperty("email_delivery")]
        [JsonConverter(typeof(EmptyableConverter<CollectionSettingUpdateEmailDeliveryOptions>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email_delivery")]
        [STJS.JsonConverter(typeof(STJEmptyableConverter<CollectionSettingUpdateEmailDeliveryOptions>))]
#endif
        internal Emptyable<CollectionSettingUpdateEmailDeliveryOptions> InternalEmailDelivery { get; set; }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public bool EmptyEmailDelivery
        {
            get => this.InternalEmailDelivery?.Empty ?? false;
            set
            {
                this.InternalEmailDelivery ??= new Emptyable<CollectionSettingUpdateEmailDeliveryOptions>();
                this.InternalEmailDelivery.Empty = value;
            }
        }

        /// <summary>
        /// Email delivery settings.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public CollectionSettingUpdateEmailDeliveryOptions EmailDelivery
        {
            get => this.InternalEmailDelivery?.Value;
            set
            {
                this.InternalEmailDelivery ??= new Emptyable<CollectionSettingUpdateEmailDeliveryOptions>();
                this.InternalEmailDelivery.Value = value;
            }
        }

        /// <summary>
        /// Optionally change the live version of the CollectionSetting. Billing Cadences and other
        /// objects that refer to this CollectionSetting will use this version when no overrides are
        /// set. Providing <c>live_version = "latest"</c> will set the CollectionSetting's
        /// <c>live_version</c> to its latest version.
        /// </summary>
        [JsonProperty("live_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("live_version")]
#endif
        public string LiveVersion { get; set; }

        /// <summary>
        /// A lookup key used to retrieve settings dynamically from a static string. This may be up
        /// to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// The ID of the PaymentMethodConfiguration object, which controls which payment methods
        /// are displayed to your customers.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_configuration")]
#endif
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Payment Method specific configuration to be stored on the object.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public CollectionSettingUpdatePaymentMethodOptionsOptions PaymentMethodOptions { get; set; }
    }
}
