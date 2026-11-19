// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupUpdateBillingSettingsOptions : INestedOptions
    {
        /// <summary>
        /// How Stripe collects payment. Set to null to restore the applicable default.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Email delivery setting. Set to null to restore the applicable default.
        /// </summary>
        [JsonProperty("email_delivery")]
        [STJS.JsonPropertyName("email_delivery")]
        public GroupUpdateBillingSettingsEmailDeliveryOptions EmailDelivery { get; set; }

        /// <summary>
        /// Settings for invoice presentation. Set to null to restore the applicable defaults.
        /// </summary>
        [JsonProperty("invoice_presentation")]
        [STJS.JsonPropertyName("invoice_presentation")]
        public GroupUpdateBillingSettingsInvoicePresentationOptions InvoicePresentation { get; set; }

        /// <summary>
        /// The amount of time until the invoice is overdue for payment. Set to null to restore the
        /// applicable default.
        /// </summary>
        [JsonProperty("invoice_time_until_due")]
        [STJS.JsonPropertyName("invoice_time_until_due")]
        public GroupUpdateBillingSettingsInvoiceTimeUntilDueOptions InvoiceTimeUntilDue { get; set; }

        /// <summary>
        /// The ID of the payment method configuration, which controls which payment methods are
        /// displayed to your customers. Set to null to restore the applicable default.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Payment Method specific configuration to be stored on the object. Set to null to clear
        /// the stored value.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public GroupUpdateBillingSettingsPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// Tax calculation settings. Set to null to restore the applicable default.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public GroupUpdateBillingSettingsTaxOptions Tax { get; set; }
    }
}
