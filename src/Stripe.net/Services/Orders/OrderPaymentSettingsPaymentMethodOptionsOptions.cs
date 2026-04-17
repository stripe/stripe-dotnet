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
        [JsonProperty("acss_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("acss_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("afterpay_clearpay", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("alipay", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("alipay")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("bancontact", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("bancontact")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("card")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("customer_balance", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("customer_balance")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("ideal", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("ideal")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("klarna", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("klarna")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("link")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("oxxo", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("oxxo")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("p24", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("p24")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("paypal", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("paypal")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("sepa_debit", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("sepa_debit")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("sofort", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("sofort")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
        [JsonProperty("wechat_pay", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("wechat_pay")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
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
