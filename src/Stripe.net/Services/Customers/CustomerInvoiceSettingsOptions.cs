// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The list of up to 4 default custom fields to be displayed on invoices for this customer.
        /// When updating, pass an empty string to remove previously-defined fields.
        /// </summary>
        [JsonProperty("custom_fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_fields")]
#endif
        public List<CustomerInvoiceSettingsCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// ID of a payment method that's attached to the customer, to be used as the customer's
        /// default payment method for subscriptions and invoices.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default footer to be displayed on invoices for this customer.
        /// </summary>
        [JsonProperty("footer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("footer")]
#endif
        public string Footer { get; set; }

        /// <summary>
        /// Default options for invoice PDF rendering for this customer.
        /// </summary>
        [JsonProperty("rendering_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rendering_options")]
#endif
        public CustomerInvoiceSettingsRenderingOptionsOptions RenderingOptions { get; set; }
    }
}
