// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsOptions : INestedOptions, IHasSetTracking
    {
        private OrderPaymentSettingsPaymentMethodOptionsAcssDebitOptions acssDebit;
        private OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpayOptions afterpayClearpay;
        private OrderPaymentSettingsPaymentMethodOptionsAlipayOptions alipay;
        private OrderPaymentSettingsPaymentMethodOptionsBancontactOptions bancontact;
        private OrderPaymentSettingsPaymentMethodOptionsCardOptions card;
        private OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions customerBalance;
        private OrderPaymentSettingsPaymentMethodOptionsIdealOptions ideal;
        private OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions klarna;
        private OrderPaymentSettingsPaymentMethodOptionsLinkOptions link;
        private OrderPaymentSettingsPaymentMethodOptionsOxxoOptions oxxo;
        private OrderPaymentSettingsPaymentMethodOptionsP24Options p24;
        private OrderPaymentSettingsPaymentMethodOptionsPaypalOptions paypal;
        private OrderPaymentSettingsPaymentMethodOptionsSepaDebitOptions sepaDebit;
        private OrderPaymentSettingsPaymentMethodOptionsSofortOptions sofort;
        private OrderPaymentSettingsPaymentMethodOptionsWechatPayOptions wechatPay;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the ACSS Debit
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit
        {
            get => this.acssDebit;
            set
            {
                this.acssDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>afterpay_clearpay</c>, this sub-hash contains details about the
        /// AfterpayClearpay payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay
        {
            get => this.afterpayClearpay;
            set
            {
                this.afterpayClearpay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>alipay</c>, this sub-hash contains details about the Alipay payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public OrderPaymentSettingsPaymentMethodOptionsAlipayOptions Alipay
        {
            get => this.alipay;
            set
            {
                this.alipay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public OrderPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact
        {
            get => this.bancontact;
            set
            {
                this.bancontact = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OrderPaymentSettingsPaymentMethodOptionsCardOptions Card
        {
            get => this.card;
            set
            {
                this.card = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Customer
        /// Balance payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance
        {
            get => this.customerBalance;
            set
            {
                this.customerBalance = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>ideal</c>, this sub-hash contains details about the iDEAL payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public OrderPaymentSettingsPaymentMethodOptionsIdealOptions Ideal
        {
            get => this.ideal;
            set
            {
                this.ideal = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>klarna</c>, this sub-hash contains details about the Klarna payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions Klarna
        {
            get => this.klarna;
            set
            {
                this.klarna = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>link</c>, this sub-hash contains details about the Link payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public OrderPaymentSettingsPaymentMethodOptionsLinkOptions Link
        {
            get => this.link;
            set
            {
                this.link = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>oxxo</c>, this sub-hash contains details about the OXXO payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public OrderPaymentSettingsPaymentMethodOptionsOxxoOptions Oxxo
        {
            get => this.oxxo;
            set
            {
                this.oxxo = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>p24</c>, this sub-hash contains details about the P24 payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public OrderPaymentSettingsPaymentMethodOptionsP24Options P24
        {
            get => this.p24;
            set
            {
                this.p24 = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>paypal</c>, this sub-hash contains details about the PayPal payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public OrderPaymentSettingsPaymentMethodOptionsPaypalOptions Paypal
        {
            get => this.paypal;
            set
            {
                this.paypal = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>sepa_debit</c>, this sub-hash contains details about the SEPA Debit
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit
        {
            get => this.sepaDebit;
            set
            {
                this.sepaDebit = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>sofort</c>, this sub-hash contains details about the Sofort payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public OrderPaymentSettingsPaymentMethodOptionsSofortOptions Sofort
        {
            get => this.sofort;
            set
            {
                this.sofort = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If paying by <c>wechat_pay</c>, this sub-hash contains details about the WeChat Pay
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public OrderPaymentSettingsPaymentMethodOptionsWechatPayOptions WechatPay
        {
            get => this.wechatPay;
            set
            {
                this.wechatPay = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
