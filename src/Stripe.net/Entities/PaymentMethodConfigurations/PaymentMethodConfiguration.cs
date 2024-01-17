// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

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
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("acss_debit")]
        public PaymentMethodConfigurationAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// Whether the configuration can be used for new payments.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("affirm")]
        public PaymentMethodConfigurationAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        public PaymentMethodConfigurationAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        public PaymentMethodConfigurationAlipay Alipay { get; set; }

        [JsonProperty("apple_pay")]
        public PaymentMethodConfigurationApplePay ApplePay { get; set; }

        /// <summary>
        /// For child configs, the Connect application associated with the configuration.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("au_becs_debit")]
        public PaymentMethodConfigurationAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        public PaymentMethodConfigurationBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        public PaymentMethodConfigurationBancontact Bancontact { get; set; }

        [JsonProperty("blik")]
        public PaymentMethodConfigurationBlik Blik { get; set; }

        [JsonProperty("boleto")]
        public PaymentMethodConfigurationBoleto Boleto { get; set; }

        [JsonProperty("card")]
        public PaymentMethodConfigurationCard Card { get; set; }

        [JsonProperty("cartes_bancaires")]
        public PaymentMethodConfigurationCartesBancaires CartesBancaires { get; set; }

        [JsonProperty("cashapp")]
        public PaymentMethodConfigurationCashapp Cashapp { get; set; }

        [JsonProperty("customer_balance")]
        public PaymentMethodConfigurationCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        public PaymentMethodConfigurationEps Eps { get; set; }

        [JsonProperty("fpx")]
        public PaymentMethodConfigurationFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        public PaymentMethodConfigurationGiropay Giropay { get; set; }

        [JsonProperty("google_pay")]
        public PaymentMethodConfigurationGooglePay GooglePay { get; set; }

        [JsonProperty("grabpay")]
        public PaymentMethodConfigurationGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
        public PaymentMethodConfigurationIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodConfigurationIdeal Ideal { get; set; }

        /// <summary>
        /// The default configuration is used whenever a payment method configuration is not
        /// specified.
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("jcb")]
        public PaymentMethodConfigurationJcb Jcb { get; set; }

        [JsonProperty("klarna")]
        public PaymentMethodConfigurationKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        public PaymentMethodConfigurationKonbini Konbini { get; set; }

        [JsonProperty("link")]
        public PaymentMethodConfigurationLink Link { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("multibanco")]
        public PaymentMethodConfigurationMultibanco Multibanco { get; set; }

        /// <summary>
        /// The configuration's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("netbanking")]
        public PaymentMethodConfigurationNetbanking Netbanking { get; set; }

        [JsonProperty("oxxo")]
        public PaymentMethodConfigurationOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        public PaymentMethodConfigurationP24 P24 { get; set; }

        /// <summary>
        /// For child configs, the configuration's parent configuration.
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("pay_by_bank")]
        public PaymentMethodConfigurationPayByBank PayByBank { get; set; }

        [JsonProperty("paynow")]
        public PaymentMethodConfigurationPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        public PaymentMethodConfigurationPaypal Paypal { get; set; }

        [JsonProperty("promptpay")]
        public PaymentMethodConfigurationPromptpay Promptpay { get; set; }

        [JsonProperty("revolut_pay")]
        public PaymentMethodConfigurationRevolutPay RevolutPay { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodConfigurationSepaDebit SepaDebit { get; set; }

        [JsonProperty("sofort")]
        public PaymentMethodConfigurationSofort Sofort { get; set; }

        [JsonProperty("upi")]
        public PaymentMethodConfigurationUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        public PaymentMethodConfigurationUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        public PaymentMethodConfigurationWechatPay WechatPay { get; set; }
    }
}
