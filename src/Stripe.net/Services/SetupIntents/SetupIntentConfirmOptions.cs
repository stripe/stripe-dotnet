// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentConfirmOptions : BaseOptions
    {
        private SetupIntentMandateDataOptions mandateData;

        /// <summary>
        /// The list of payment method types to allow for this SetupIntent. Stripe will only use
        /// methods in this list when determining the payment methods to offer. A list of valid
        /// payment method types can be found <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-type">here</a>.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>bizum</c>, <c>blik</c>, <c>boku_promptpay</c>,
        /// <c>boleto</c>, <c>capchase_pay</c>, <c>card</c>, <c>cashapp</c>, <c>check_scan</c>,
        /// <c>click_to_pay</c>, <c>crypto</c>, <c>customer_balance</c>, <c>demo_pay</c>,
        /// <c>duitnow</c>, <c>dummy_auth_push</c>, <c>dummy_passthrough_card</c>, <c>edenred</c>,
        /// <c>eps</c>, <c>fpx</c>, <c>gcash</c>, <c>getbalance</c>, <c>gift_card</c>,
        /// <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>,
        /// <c>kakao_pay</c>, <c>klarna</c>, <c>knet</c>, <c>konbini</c>, <c>kr_card</c>,
        /// <c>kr_market</c>, <c>kriya</c>, <c>link</c>, <c>mb_way</c>, <c>mobilepay</c>,
        /// <c>momo</c>, <c>mondu</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>netbanking</c>,
        /// <c>ng_bank</c>, <c>ng_bank_transfer</c>, <c>ng_card</c>, <c>ng_market</c>,
        /// <c>ng_ussd</c>, <c>ng_wallet</c>, <c>nz_bank_account</c>, <c>octopus</c>, <c>oxxo</c>,
        /// <c>p24</c>, <c>paper_check</c>, <c>pay_by_bank</c>, <c>payco</c>, <c>paynow</c>,
        /// <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>qris</c>,
        /// <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>,
        /// <c>scalapay</c>, <c>sepa_debit</c>, <c>sequra</c>, <c>shop_pay</c>, <c>shopeepay</c>,
        /// <c>sofort</c>, <c>south_korea_market</c>, <c>stripe_balance</c>, <c>sunbit</c>,
        /// <c>swish</c>, <c>tamara</c>, <c>test_pay</c>, <c>touch_n_go</c>, <c>truemoney</c>,
        /// <c>twint</c>, <c>upi</c>, <c>us_bank_account</c>, <c>us_cash_voucher</c>, <c>vipps</c>,
        /// <c>wechat_pay</c>, <c>wero</c>, or <c>zip</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("allowed_payment_method_types")]
        [STJS.JsonPropertyName("allowed_payment_method_types")]
        public List<string> AllowedPaymentMethodTypes { get; set; }

        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// ID of the ConfirmationToken used to confirm this SetupIntent.
        ///
        /// If the provided ConfirmationToken contains properties that are also being provided in
        /// this request, such as <c>payment_method</c>, then the values in this request will take
        /// precedence.
        /// </summary>
        [JsonProperty("confirmation_token")]
        [STJS.JsonPropertyName("confirmation_token")]
        public string ConfirmationToken { get; set; }

        [JsonProperty("mandate_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("mandate_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SetupIntentMandateDataOptions MandateData
        {
            get => this.mandateData;
            set
            {
                this.mandateData = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// ID of the payment method (a PaymentMethod, Card, or saved Source object) to attach to
        /// this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// When included, this hash creates a PaymentMethod that is set as the <a
        /// href="https://docs.stripe.com/api/setup_intents/object#setup_intent_object-payment_method"><c>payment_method</c></a>
        /// value in the SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_data")]
        [STJS.JsonPropertyName("payment_method_data")]
        public SetupIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this SetupIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public SetupIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate on the payment
        /// method's app or site. If you'd prefer to redirect to a mobile application, you can
        /// alternatively supply an application URI scheme. This parameter is only used for cards
        /// and other redirect-based payment methods.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Provides industry-specific information about the SetupIntent.
        /// </summary>
        [JsonProperty("setup_details")]
        [STJS.JsonPropertyName("setup_details")]
        public SetupIntentSetupDetailsOptions SetupDetails { get; set; }

        /// <summary>
        /// Set to <c>true</c> when confirming server-side and using Stripe.js, iOS, or Android
        /// client-side SDKs to handle the next actions.
        /// </summary>
        [JsonProperty("use_stripe_sdk")]
        [STJS.JsonPropertyName("use_stripe_sdk")]
        public bool? UseStripeSdk { get; set; }
    }
}
