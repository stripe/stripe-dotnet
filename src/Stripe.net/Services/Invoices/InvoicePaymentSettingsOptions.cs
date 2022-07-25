// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsOptions : INestedOptions
    {
        /// <summary>
        /// ID of the mandate to be used for this invoice. It must correspond to the payment method
        /// used to pay the invoice, including the invoice's default_payment_method or
        /// default_source, if set.
        /// </summary>
        [JsonProperty("default_mandate")]
        public string DefaultMandate { get; set; }

        /// <summary>
        /// Payment-method-specific configuration to provide to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public InvoicePaymentSettingsPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) to provide to the invoice’s PaymentIntent.
        /// If not set, Stripe attempts to automatically determine the types to use by looking at
        /// the invoice’s default payment method, the subscription’s default payment method, the
        /// customer’s default payment method, and your <a
        /// href="https://dashboard.stripe.com/settings/billing/invoice">invoice template
        /// settings</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }
    }
}
