// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CollectionSettingCreateOptions : BaseOptions
    {
        /// <summary>
        /// Either automatic, or send_invoice. When charging automatically, Stripe will attempt to
        /// pay this bill at the end of the period using the payment method attached to the payer
        /// profile. When sending an invoice, Stripe will email your payer profile an invoice with
        /// payment instructions. Defaults to automatic.
        /// One of: <c>automatic</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// An optional customer-facing display name for the CollectionSetting object. Maximum
        /// length of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Email delivery setting.
        /// </summary>
        [JsonProperty("email_delivery")]
        [STJS.JsonPropertyName("email_delivery")]
        public CollectionSettingCreateEmailDeliveryOptions EmailDelivery { get; set; }

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
        public CollectionSettingCreatePaymentMethodOptionsOptions PaymentMethodOptions { get; set; }
    }
}
