// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    /// <summary>
    /// An object detailing payment method configurations.
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
        /// The Connect application associated with this configuration.
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
        /// The default configuration is used whenever no payment method configuration is specified.
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
        /// Configuration name.
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
        /// The configuration's parent configuration.
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("pay_by_bank")]
        public PaymentMethodConfigurationPayByBank PayByBank { get; set; }

        [JsonProperty("paynow")]
        public PaymentMethodConfigurationPaynow Paynow { get; set; }

        [JsonProperty("promptpay")]
        public PaymentMethodConfigurationPromptpay Promptpay { get; set; }

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
