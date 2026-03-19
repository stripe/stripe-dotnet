// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// PaymentMethodConfigurations control which payment methods are displayed to your
    /// customers when you don't explicitly specify payment method types. You can have multiple
    /// configurations with different sets of payment methods for different scenarios.
    ///
    /// There are two types of PaymentMethodConfigurations. Which is used depends on the <a
    /// href="https://docs.stripe.com/connect/charges">charge type</a>:.
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
    /// href="https://docs.stripe.com/connect/payment-method-configurations">Payment Method
    /// Configurations API</a> - <a
    /// href="https://docs.stripe.com/payments/multiple-payment-method-configs">Multiple
    /// configurations on dynamic payment methods</a> - <a
    /// href="https://docs.stripe.com/connect/multiple-payment-method-configurations">Multiple
    /// configurations for your Connect accounts</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodConfiguration : StripeEntity<PaymentMethodConfiguration>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public PaymentMethodConfigurationAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// Whether the configuration can be used for new payments.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentMethodConfigurationAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentMethodConfigurationAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentMethodConfigurationAlipay Alipay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentMethodConfigurationAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentMethodConfigurationAmazonPay AmazonPay { get; set; }

        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public PaymentMethodConfigurationApplePay ApplePay { get; set; }

        /// <summary>
        /// For child configs, the Connect application associated with the configuration.
        /// </summary>
        [JsonProperty("application")]
        [STJS.JsonPropertyName("application")]
        public string Application { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentMethodConfigurationAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentMethodConfigurationBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentMethodConfigurationBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentMethodConfigurationBillie Billie { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentMethodConfigurationBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentMethodConfigurationBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentMethodConfigurationCard Card { get; set; }

        [JsonProperty("cartes_bancaires")]
        [STJS.JsonPropertyName("cartes_bancaires")]
        public PaymentMethodConfigurationCartesBancaires CartesBancaires { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentMethodConfigurationCashapp Cashapp { get; set; }

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentMethodConfigurationCrypto Crypto { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentMethodConfigurationCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentMethodConfigurationEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentMethodConfigurationFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentMethodConfigurationGiropay Giropay { get; set; }

        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public PaymentMethodConfigurationGooglePay GooglePay { get; set; }

        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public PaymentMethodConfigurationGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentMethodConfigurationGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public PaymentMethodConfigurationIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentMethodConfigurationIdeal Ideal { get; set; }

        /// <summary>
        /// The default configuration is used whenever a payment method configuration is not
        /// specified.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("jcb")]
        [STJS.JsonPropertyName("jcb")]
        public PaymentMethodConfigurationJcb Jcb { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentMethodConfigurationKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentMethodConfigurationKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentMethodConfigurationKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentMethodConfigurationKrCard KrCard { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentMethodConfigurationLink Link { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentMethodConfigurationMbWay MbWay { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentMethodConfigurationMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentMethodConfigurationMultibanco Multibanco { get; set; }

        /// <summary>
        /// The configuration's name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentMethodConfigurationNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentMethodConfigurationNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentMethodConfigurationOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentMethodConfigurationP24 P24 { get; set; }

        /// <summary>
        /// For child configs, the configuration's parent configuration.
        /// </summary>
        [JsonProperty("parent")]
        [STJS.JsonPropertyName("parent")]
        public string Parent { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentMethodConfigurationPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentMethodConfigurationPayco Payco { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentMethodConfigurationPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentMethodConfigurationPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public PaymentMethodConfigurationPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentMethodConfigurationPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentMethodConfigurationPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentMethodConfigurationPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qris")]
#endif
        public PaymentMethodConfigurationQris Qris { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentMethodConfigurationRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentMethodConfigurationSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentMethodConfigurationSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentMethodConfigurationSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public PaymentMethodConfigurationShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentMethodConfigurationSofort Sofort { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentMethodConfigurationSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentMethodConfigurationTwint Twint { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentMethodConfigurationUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentMethodConfigurationWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentMethodConfigurationZip Zip { get; set; }
    }
}
