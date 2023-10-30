// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettings : StripeEntity<SubscriptionPaymentSettings>
    {
        /// <summary>
        /// Payment-method-specific configuration to provide to invoices created by the
        /// subscription.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types to provide to every invoice created by the
        /// subscription. If not set, Stripe attempts to automatically determine the types to use by
        /// looking at the invoice’s default payment method, the subscription’s default payment
        /// method, the customer’s default payment method, and your <a
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

        /// <summary>
        /// Either <c>off</c>, or <c>on_subscription</c>. With <c>on_subscription</c> Stripe updates
        /// <c>subscription.default_payment_method</c> when a subscription payment succeeds.
        /// One of: <c>off</c>, or <c>on_subscription</c>.
        /// </summary>
        [JsonProperty("save_default_payment_method")]
        public string SaveDefaultPaymentMethod { get; set; }
    }
}
