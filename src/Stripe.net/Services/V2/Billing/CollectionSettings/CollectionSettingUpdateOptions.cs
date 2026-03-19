// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
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
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// An optional customer-facing display name for the CollectionSetting object. To remove the
        /// display name, set it to an empty string in the request. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Email delivery settings.
        /// </summary>
        [JsonProperty("email_delivery")]
        [STJS.JsonPropertyName("email_delivery")]
        public CollectionSettingUpdateEmailDeliveryOptions EmailDelivery { get; set; }

        /// <summary>
        /// Optionally change the live version of the CollectionSetting. Billing Cadences and other
        /// objects that refer to this CollectionSetting will use this version when no overrides are
        /// set. Providing <c>live_version = "latest"</c> will set the CollectionSetting's
        /// <c>live_version</c> to its latest version.
        /// </summary>
        [JsonProperty("live_version")]
        [STJS.JsonPropertyName("live_version")]
        public string LiveVersion { get; set; }

        /// <summary>
        /// A lookup key used to retrieve settings dynamically from a static string. This may be up
        /// to 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// The ID of the PaymentMethodConfiguration object, which controls which payment methods
        /// are displayed to your customers.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Payment Method specific configuration to be stored on the object.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public CollectionSettingUpdatePaymentMethodOptionsOptions PaymentMethodOptions { get; set; }
    }
}
