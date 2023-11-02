// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoicePaymentSettings : StripeEntity<InvoicePaymentSettings>
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
        public InvoicePaymentSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) to provide to the invoice’s PaymentIntent.
        /// If not set, Stripe attempts to automatically determine the types to use by looking at
        /// the invoice’s default payment method, the subscription’s default payment method, the
        /// customer’s default payment method, and your <a
        /// href="https://dashboard.stripe.com/settings/billing/invoice">invoice template
        /// settings</a>.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>customer_balance</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>,
        /// <c>ideal</c>, <c>konbini</c>, <c>link</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>promptpay</c>, <c>sepa_credit_transfer</c>, <c>sepa_debit</c>, <c>sofort</c>,
        /// <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }
    }
}
