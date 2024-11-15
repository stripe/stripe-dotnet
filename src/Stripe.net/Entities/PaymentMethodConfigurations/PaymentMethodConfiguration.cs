// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// PaymentMethodConfigurations control which payment methods are displayed to your
    /// customers when you don't explicitly specify payment method types. You can have multiple
    /// configurations with different sets of payment methods for different scenarios.
    ///
    /// There are two types of PaymentMethodConfigurations. Which is used depends on the <a
    /// href="https://stripe.com/docs/connect/charges">charge type</a>:.
    ///
    /// <strong>Direct</strong> configurations apply to payments created on your account,
    /// including Connect destination charges, Connect separate charges and transfers, and
    /// payments not involving Connect.
    ///
    /// <strong>Child</strong> configurations apply to payments created on your connected
    /// accounts using direct charges, and charges with the on_behalf_of parameter.
    ///
    /// Child configurations have a <c>parent</c> that sets default values and controls which
    /// settings connected accounts may override. You can specify a parent ID at payment time,
    /// and Stripe will automatically resolve the connected account’s associated child
    /// configuration. Parent configurations are <a
    /// href="https://dashboard.stripe.com/settings/payment_methods/connected_accounts">managed
    /// in the dashboard</a> and are not available in this API.
    ///
    /// Related guides: - <a
    /// href="https://stripe.com/docs/connect/payment-method-configurations">Payment Method
    /// Configurations API</a> - <a
    /// href="https://stripe.com/docs/payments/multiple-payment-method-configs">Multiple
    /// configurations on dynamic payment methods</a> - <a
    /// href="https://stripe.com/docs/connect/multiple-payment-method-configurations">Multiple
    /// configurations for your Connect accounts</a>.
    /// </summary>
    public class PaymentMethodConfiguration : StripeEntity<PaymentMethodConfiguration>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif

        public PaymentMethodConfigurationAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// Whether the configuration can be used for new payments.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif

        public bool Active { get; set; }

        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif

        public PaymentMethodConfigurationAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif

        public PaymentMethodConfigurationAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif

        public PaymentMethodConfigurationAlipay Alipay { get; set; }

        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif

        public PaymentMethodConfigurationAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif

        public PaymentMethodConfigurationAmazonPay AmazonPay { get; set; }

        [JsonProperty("apple_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("apple_pay")]
#endif

        public PaymentMethodConfigurationApplePay ApplePay { get; set; }

        /// <summary>
        /// For child configs, the Connect application associated with the configuration.
        /// </summary>
        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
#endif

        public string Application { get; set; }

        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif

        public PaymentMethodConfigurationAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif

        public PaymentMethodConfigurationBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif

        public PaymentMethodConfigurationBancontact Bancontact { get; set; }

        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif

        public PaymentMethodConfigurationBlik Blik { get; set; }

        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif

        public PaymentMethodConfigurationBoleto Boleto { get; set; }

        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif

        public PaymentMethodConfigurationCard Card { get; set; }

        [JsonProperty("cartes_bancaires")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cartes_bancaires")]
#endif

        public PaymentMethodConfigurationCartesBancaires CartesBancaires { get; set; }

        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif

        public PaymentMethodConfigurationCashapp Cashapp { get; set; }

        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif

        public PaymentMethodConfigurationCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif

        public PaymentMethodConfigurationEps Eps { get; set; }

        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif

        public PaymentMethodConfigurationFpx Fpx { get; set; }

        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif

        public PaymentMethodConfigurationGiropay Giropay { get; set; }

        [JsonProperty("google_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("google_pay")]
#endif

        public PaymentMethodConfigurationGooglePay GooglePay { get; set; }

        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif

        public PaymentMethodConfigurationGrabpay Grabpay { get; set; }

        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif

        public PaymentMethodConfigurationIdeal Ideal { get; set; }

        /// <summary>
        /// The default configuration is used whenever a payment method configuration is not
        /// specified.
        /// </summary>
        [JsonProperty("is_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_default")]
#endif

        public bool IsDefault { get; set; }

        [JsonProperty("jcb")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jcb")]
#endif

        public PaymentMethodConfigurationJcb Jcb { get; set; }

        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif

        public PaymentMethodConfigurationKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif

        public PaymentMethodConfigurationKonbini Konbini { get; set; }

        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif

        public PaymentMethodConfigurationLink Link { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif

        public bool Livemode { get; set; }

        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif

        public PaymentMethodConfigurationMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif

        public PaymentMethodConfigurationMultibanco Multibanco { get; set; }

        /// <summary>
        /// The configuration's name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif

        public PaymentMethodConfigurationOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif

        public PaymentMethodConfigurationP24 P24 { get; set; }

        /// <summary>
        /// For child configs, the configuration's parent configuration.
        /// </summary>
        [JsonProperty("parent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("parent")]
#endif

        public string Parent { get; set; }

        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif

        public PaymentMethodConfigurationPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif

        public PaymentMethodConfigurationPaypal Paypal { get; set; }

        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif

        public PaymentMethodConfigurationPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif

        public PaymentMethodConfigurationRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif

        public PaymentMethodConfigurationSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif

        public PaymentMethodConfigurationSofort Sofort { get; set; }

        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif

        public PaymentMethodConfigurationSwish Swish { get; set; }

        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif

        public PaymentMethodConfigurationTwint Twint { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif

        public PaymentMethodConfigurationUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif

        public PaymentMethodConfigurationWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif

        public PaymentMethodConfigurationZip Zip { get; set; }
    }
}
