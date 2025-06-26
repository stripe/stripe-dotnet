// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettings : StripeEntity<SubscriptionPaymentSettings>
    {
        /// <summary>
        /// Payment-method-specific configuration to provide to invoices created by the
        /// subscription.
        /// </summary>
        [JsonProperty("payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_options")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types to provide to every invoice created by the
        /// subscription. If not set, Stripe attempts to automatically determine the types to use by
        /// looking at the invoice’s default payment method, the subscription’s default payment
        /// method, the customer’s default payment method, and your <a
        /// href="https://dashboard.stripe.com/settings/billing/invoice">invoice template
        /// settings</a>.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>, <c>affirm</c>,
        /// <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>,
        /// <c>boleto</c>, <c>card</c>, <c>cashapp</c>, <c>crypto</c>, <c>customer_balance</c>,
        /// <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>,
        /// <c>jp_credit_transfer</c>, <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>,
        /// <c>kr_card</c>, <c>link</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>p24</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>promptpay</c>, <c>revolut_pay</c>, <c>sepa_credit_transfer</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_types")]
#endif
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// Configure whether Stripe updates <c>subscription.default_payment_method</c> when payment
        /// succeeds. Defaults to <c>off</c>.
        /// One of: <c>off</c>, or <c>on_subscription</c>.
        /// </summary>
        [JsonProperty("save_default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("save_default_payment_method")]
#endif
        public string SaveDefaultPaymentMethod { get; set; }
    }
}
