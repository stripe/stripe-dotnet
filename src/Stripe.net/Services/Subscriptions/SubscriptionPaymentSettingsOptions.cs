// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsOptions : INestedOptions, IHasSetTracking
    {
        private List<string> paymentMethodTypes;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Payment-method-specific configuration to provide to invoices created by the
        /// subscription.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of payment method types (e.g. card) to provide to the invoice’s PaymentIntent.
        /// If not set, Stripe attempts to automatically determine the types to use by looking at
        /// the invoice’s default payment method, the subscription’s default payment method, the
        /// customer’s default payment method, and your <a
        /// href="https://dashboard.stripe.com/settings/billing/invoice">invoice template
        /// settings</a>. Should not be specified with payment_method_configuration.
        /// One of: <c>ach_credit_transfer</c>, <c>ach_debit</c>, <c>acss_debit</c>, <c>affirm</c>,
        /// <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>,
        /// <c>bizum</c>, <c>boleto</c>, <c>card</c>, <c>cashapp</c>, <c>check_scan</c>,
        /// <c>crypto</c>, <c>custom</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>,
        /// <c>giropay</c>, <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>,
        /// <c>jp_credit_transfer</c>, <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>,
        /// <c>kr_card</c>, <c>link</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>, <c>paynow</c>,
        /// <c>paypal</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>revolut_pay</c>,
        /// <c>sepa_credit_transfer</c>, <c>sepa_debit</c>, <c>sofort</c>, <c>stripe_balance</c>,
        /// <c>swish</c>, <c>upi</c>, <c>us_bank_account</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        [STJS.JsonPropertyName("payment_method_types")]
        public List<string> PaymentMethodTypes
        {
            get => this.paymentMethodTypes;
            set
            {
                this.paymentMethodTypes = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Configure whether Stripe updates <c>subscription.default_payment_method</c> when payment
        /// succeeds. Defaults to <c>off</c> if unspecified.
        /// One of: <c>off</c>, or <c>on_subscription</c>.
        /// </summary>
        [JsonProperty("save_default_payment_method")]
        [STJS.JsonPropertyName("save_default_payment_method")]
        public string SaveDefaultPaymentMethod { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
