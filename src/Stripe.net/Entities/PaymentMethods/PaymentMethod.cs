// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// PaymentMethod objects represent your customer's payment instruments. You can use them
    /// with <a href="https://docs.stripe.com/payments/payment-intents">PaymentIntents</a> to
    /// collect payments or save them to Customer objects to store instrument details for future
    /// payments.
    ///
    /// Related guides: <a href="https://docs.stripe.com/payments/payment-methods">Payment
    /// Methods</a> and <a href="https://docs.stripe.com/payments/more-payment-scenarios">More
    /// Payment Scenarios</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethod : StripeEntity<PaymentMethod>, IHasId, IHasMetadata, IHasObject
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
        public PaymentMethodAcssDebit AcssDebit { get; set; }

        [JsonProperty("affirm")]
        [STJS.JsonPropertyName("affirm")]
        public PaymentMethodAffirm Affirm { get; set; }

        [JsonProperty("afterpay_clearpay")]
        [STJS.JsonPropertyName("afterpay_clearpay")]
        public PaymentMethodAfterpayClearpay AfterpayClearpay { get; set; }

        [JsonProperty("alipay")]
        [STJS.JsonPropertyName("alipay")]
        public PaymentMethodAlipay Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to “unspecified”.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
        [STJS.JsonPropertyName("allow_redisplay")]
        public string AllowRedisplay { get; set; }

        [JsonProperty("alma")]
        [STJS.JsonPropertyName("alma")]
        public PaymentMethodAlma Alma { get; set; }

        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public PaymentMethodAmazonPay AmazonPay { get; set; }

        [JsonProperty("au_becs_debit")]
        [STJS.JsonPropertyName("au_becs_debit")]
        public PaymentMethodAuBecsDebit AuBecsDebit { get; set; }

        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public PaymentMethodBacsDebit BacsDebit { get; set; }

        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public PaymentMethodBancontact Bancontact { get; set; }

        [JsonProperty("billie")]
        [STJS.JsonPropertyName("billie")]
        public PaymentMethodBillie Billie { get; set; }

        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public PaymentMethodBillingDetails BillingDetails { get; set; }

        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public PaymentMethodBlik Blik { get; set; }

        [JsonProperty("boleto")]
        [STJS.JsonPropertyName("boleto")]
        public PaymentMethodBoleto Boleto { get; set; }

        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentMethodCard Card { get; set; }

        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public PaymentMethodCardPresent CardPresent { get; set; }

        [JsonProperty("cashapp")]
        [STJS.JsonPropertyName("cashapp")]
        public PaymentMethodCashapp Cashapp { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("crypto")]
        [STJS.JsonPropertyName("crypto")]
        public PaymentMethodCrypto Crypto { get; set; }

        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentMethodCustom Custom { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the Customer to which this PaymentMethod is saved. This will not be set when
        /// the PaymentMethod has not been saved to a Customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public PaymentMethodCustomerBalance CustomerBalance { get; set; }

        [JsonProperty("eps")]
        [STJS.JsonPropertyName("eps")]
        public PaymentMethodEps Eps { get; set; }

        [JsonProperty("fpx")]
        [STJS.JsonPropertyName("fpx")]
        public PaymentMethodFpx Fpx { get; set; }

        [JsonProperty("giropay")]
        [STJS.JsonPropertyName("giropay")]
        public PaymentMethodGiropay Giropay { get; set; }

        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public PaymentMethodGopay Gopay { get; set; }

        [JsonProperty("grabpay")]
        [STJS.JsonPropertyName("grabpay")]
        public PaymentMethodGrabpay Grabpay { get; set; }

        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public PaymentMethodIdBankTransfer IdBankTransfer { get; set; }

        [JsonProperty("ideal")]
        [STJS.JsonPropertyName("ideal")]
        public PaymentMethodIdeal Ideal { get; set; }

        [JsonProperty("interac_present")]
        [STJS.JsonPropertyName("interac_present")]
        public PaymentMethodInteracPresent InteracPresent { get; set; }

        [JsonProperty("kakao_pay")]
        [STJS.JsonPropertyName("kakao_pay")]
        public PaymentMethodKakaoPay KakaoPay { get; set; }

        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public PaymentMethodKlarna Klarna { get; set; }

        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public PaymentMethodKonbini Konbini { get; set; }

        [JsonProperty("kr_card")]
        [STJS.JsonPropertyName("kr_card")]
        public PaymentMethodKrCard KrCard { get; set; }

        /// <summary>
        /// The Mandate object of the most recently created Mandate associated with this payment
        /// method.
        /// </summary>
        [JsonProperty("latest_active_mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_active_mandate")]
#endif
        public Mandate LatestActiveMandate { get; set; }

        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public PaymentMethodLink Link { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("mb_way")]
        [STJS.JsonPropertyName("mb_way")]
        public PaymentMethodMbWay MbWay { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("mobilepay")]
        [STJS.JsonPropertyName("mobilepay")]
        public PaymentMethodMobilepay Mobilepay { get; set; }

        [JsonProperty("multibanco")]
        [STJS.JsonPropertyName("multibanco")]
        public PaymentMethodMultibanco Multibanco { get; set; }

        [JsonProperty("naver_pay")]
        [STJS.JsonPropertyName("naver_pay")]
        public PaymentMethodNaverPay NaverPay { get; set; }

        [JsonProperty("nz_bank_account")]
        [STJS.JsonPropertyName("nz_bank_account")]
        public PaymentMethodNzBankAccount NzBankAccount { get; set; }

        [JsonProperty("oxxo")]
        [STJS.JsonPropertyName("oxxo")]
        public PaymentMethodOxxo Oxxo { get; set; }

        [JsonProperty("p24")]
        [STJS.JsonPropertyName("p24")]
        public PaymentMethodP24 P24 { get; set; }

        [JsonProperty("pay_by_bank")]
        [STJS.JsonPropertyName("pay_by_bank")]
        public PaymentMethodPayByBank PayByBank { get; set; }

        [JsonProperty("payco")]
        [STJS.JsonPropertyName("payco")]
        public PaymentMethodPayco Payco { get; set; }

        [JsonProperty("paynow")]
        [STJS.JsonPropertyName("paynow")]
        public PaymentMethodPaynow Paynow { get; set; }

        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public PaymentMethodPaypal Paypal { get; set; }

        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public PaymentMethodPaypay Paypay { get; set; }

        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public PaymentMethodPayto Payto { get; set; }

        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public PaymentMethodPix Pix { get; set; }

        [JsonProperty("promptpay")]
        [STJS.JsonPropertyName("promptpay")]
        public PaymentMethodPromptpay Promptpay { get; set; }

        [JsonProperty("qris")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qris")]
#endif
        public PaymentMethodQris Qris { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
        [STJS.JsonPropertyName("radar_options")]
        public PaymentMethodRadarOptions RadarOptions { get; set; }

        [JsonProperty("rechnung")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rechnung")]
#endif
        public PaymentMethodRechnung Rechnung { get; set; }

        [JsonProperty("revolut_pay")]
        [STJS.JsonPropertyName("revolut_pay")]
        public PaymentMethodRevolutPay RevolutPay { get; set; }

        [JsonProperty("samsung_pay")]
        [STJS.JsonPropertyName("samsung_pay")]
        public PaymentMethodSamsungPay SamsungPay { get; set; }

        [JsonProperty("satispay")]
        [STJS.JsonPropertyName("satispay")]
        public PaymentMethodSatispay Satispay { get; set; }

        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public PaymentMethodSepaDebit SepaDebit { get; set; }

        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public PaymentMethodShopeepay Shopeepay { get; set; }

        [JsonProperty("sofort")]
        [STJS.JsonPropertyName("sofort")]
        public PaymentMethodSofort Sofort { get; set; }

        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public PaymentMethodStripeBalance StripeBalance { get; set; }

        [JsonProperty("swish")]
        [STJS.JsonPropertyName("swish")]
        public PaymentMethodSwish Swish { get; set; }

        [JsonProperty("twint")]
        [STJS.JsonPropertyName("twint")]
        public PaymentMethodTwint Twint { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>card_present</c>, <c>cashapp</c>, <c>crypto</c>, <c>custom</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>gopay</c>,
        /// <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>, <c>interac_present</c>,
        /// <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>link</c>,
        /// <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>qris</c>, <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>,
        /// <c>sepa_debit</c>, <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>, <c>swish</c>,
        /// <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public PaymentMethodUpi Upi { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public PaymentMethodUsBankAccount UsBankAccount { get; set; }

        [JsonProperty("wechat_pay")]
        [STJS.JsonPropertyName("wechat_pay")]
        public PaymentMethodWechatPay WechatPay { get; set; }

        [JsonProperty("zip")]
        [STJS.JsonPropertyName("zip")]
        public PaymentMethodZip Zip { get; set; }
    }
}
