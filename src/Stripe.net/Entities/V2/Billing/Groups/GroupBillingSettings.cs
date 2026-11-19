// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GroupBillingSettings : StripeEntity<GroupBillingSettings>
    {
        /// <summary>
        /// How Stripe collects payment.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Email delivery setting.
        /// </summary>
        [JsonProperty("email_delivery")]
        [STJS.JsonPropertyName("email_delivery")]
        public GroupBillingSettingsEmailDelivery EmailDelivery { get; set; }

        /// <summary>
        /// Settings for invoice presentation.
        /// </summary>
        [JsonProperty("invoice_presentation")]
        [STJS.JsonPropertyName("invoice_presentation")]
        public GroupBillingSettingsInvoicePresentation InvoicePresentation { get; set; }

        /// <summary>
        /// The amount of time until the invoice is overdue for payment.
        /// </summary>
        [JsonProperty("invoice_time_until_due")]
        [STJS.JsonPropertyName("invoice_time_until_due")]
        public GroupBillingSettingsInvoiceTimeUntilDue InvoiceTimeUntilDue { get; set; }

        /// <summary>
        /// The ID of the payment method configuration, which controls which payment methods are
        /// displayed to your customers.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration { get; set; }

        /// <summary>
        /// Payment Method specific configuration to be stored on the object.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public GroupBillingSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// Settings for calculating tax.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public GroupBillingSettingsTax Tax { get; set; }
    }
}
