// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// If this is an <c>acss_debit</c> PaymentMethod, this hash contains details about the ACSS
        /// Debit payment method.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public PaymentMethodAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this hash contains details about the Affirm
        /// payment method.
        /// </summary>
        [JsonProperty("affirm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm")]
#endif
        public PaymentMethodAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is an <c>AfterpayClearpay</c> PaymentMethod, this hash contains details about
        /// the AfterpayClearpay payment method.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay")]
#endif
        public PaymentMethodAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is an <c>Alipay</c> PaymentMethod, this hash contains details about the Alipay
        /// payment method.
        /// </summary>
        [JsonProperty("alipay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alipay")]
#endif
        public PaymentMethodAlipayOptions Alipay { get; set; }

        /// <summary>
        /// This field indicates whether this payment method can be shown again to its customer in a
        /// checkout flow. Stripe products such as Checkout and Elements use this field to determine
        /// whether a payment method can be shown as a saved payment method in a checkout flow. The
        /// field defaults to <c>unspecified</c>.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay")]
#endif
        public string AllowRedisplay { get; set; }

        /// <summary>
        /// If this is a Alma PaymentMethod, this hash contains details about the Alma payment
        /// method.
        /// </summary>
        [JsonProperty("alma")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma")]
#endif
        public PaymentMethodAlmaOptions Alma { get; set; }

        /// <summary>
        /// If this is a AmazonPay PaymentMethod, this hash contains details about the AmazonPay
        /// payment method.
        /// </summary>
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public PaymentMethodAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// If this is an <c>au_becs_debit</c> PaymentMethod, this hash contains details about the
        /// bank account.
        /// </summary>
        [JsonProperty("au_becs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit")]
#endif
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this hash contains details about the Bacs
        /// Direct Debit bank account.
        /// </summary>
        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public PaymentMethodBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this hash contains details about the
        /// Bancontact payment method.
        /// </summary>
        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public PaymentMethodBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// If this is a <c>billie</c> PaymentMethod, this hash contains details about the Billie
        /// payment method.
        /// </summary>
        [JsonProperty("billie")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billie")]
#endif
        public PaymentMethodBillieOptions Billie { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this hash contains details about the BLIK
        /// payment method.
        /// </summary>
        [JsonProperty("blik")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik")]
#endif
        public PaymentMethodBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this hash contains details about the Boleto
        /// payment method.
        /// </summary>
        [JsonProperty("boleto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto")]
#endif
        public PaymentMethodBoletoOptions Boleto { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, this hash contains the user's card details. For
        /// backwards compatibility, you can alternatively provide a Stripe token (e.g., for Apple
        /// Pay, Amex Express Checkout, or legacy Checkout) into the card hash with format <c>card:
        /// {token: "tok_visa"}</c>. When providing a card number, you must meet the requirements
        /// for <a href="https://stripe.com/docs/security#validating-pci-compliance">PCI
        /// compliance</a>. We strongly recommend using Stripe.js instead of interacting with this
        /// API directly.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this hash contains details about the Cash App
        /// Pay payment method.
        /// </summary>
        [JsonProperty("cashapp")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp")]
#endif
        public PaymentMethodCashappOptions Cashapp { get; set; }

        /// <summary>
        /// If this is a Crypto PaymentMethod, this hash contains details about the Crypto payment
        /// method.
        /// </summary>
        [JsonProperty("crypto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto")]
#endif
        public PaymentMethodCryptoOptions Crypto { get; set; }

        /// <summary>
        /// If this is a <c>custom</c> PaymentMethod, this hash contains details about the Custom
        /// payment method.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentMethodCustomOptions Custom { get; set; }

        /// <summary>
        /// The <c>Customer</c> to whom the original PaymentMethod is attached.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// If this is a <c>customer_balance</c> PaymentMethod, this hash contains details about the
        /// CustomerBalance payment method.
        /// </summary>
        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public PaymentMethodCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is an <c>eps</c> PaymentMethod, this hash contains details about the EPS payment
        /// method.
        /// </summary>
        [JsonProperty("eps")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps")]
#endif
        public PaymentMethodEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is an <c>fpx</c> PaymentMethod, this hash contains details about the FPX payment
        /// method.
        /// </summary>
        [JsonProperty("fpx")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx")]
#endif
        public PaymentMethodFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this hash contains details about the Giropay
        /// payment method.
        /// </summary>
        [JsonProperty("giropay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay")]
#endif
        public PaymentMethodGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a Gopay PaymentMethod, this hash contains details about the Gopay payment
        /// method.
        /// </summary>
        [JsonProperty("gopay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gopay")]
#endif
        public PaymentMethodGopayOptions Gopay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this hash contains details about the GrabPay
        /// payment method.
        /// </summary>
        [JsonProperty("grabpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay")]
#endif
        public PaymentMethodGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is an <c>IdBankTransfer</c> PaymentMethod, this hash contains details about the
        /// IdBankTransfer payment method.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public PaymentMethodIdBankTransferOptions IdBankTransfer { get; set; }

        /// <summary>
        /// If this is an <c>ideal</c> PaymentMethod, this hash contains details about the iDEAL
        /// payment method.
        /// </summary>
        [JsonProperty("ideal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal")]
#endif
        public PaymentMethodIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is an <c>interac_present</c> PaymentMethod, this hash contains details about the
        /// Interac Present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interac_present")]
#endif
        public PaymentMethodInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>kakao_pay</c> PaymentMethod, this hash contains details about the Kakao
        /// Pay payment method.
        /// </summary>
        [JsonProperty("kakao_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay")]
#endif
        public PaymentMethodKakaoPayOptions KakaoPay { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this hash contains details about the Klarna
        /// payment method.
        /// </summary>
        [JsonProperty("klarna")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna")]
#endif
        public PaymentMethodKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this hash contains details about the Konbini
        /// payment method.
        /// </summary>
        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public PaymentMethodKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is a <c>kr_card</c> PaymentMethod, this hash contains details about the Korean
        /// Card payment method.
        /// </summary>
        [JsonProperty("kr_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card")]
#endif
        public PaymentMethodKrCardOptions KrCard { get; set; }

        /// <summary>
        /// If this is an <c>Link</c> PaymentMethod, this hash contains details about the Link
        /// payment method.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public PaymentMethodLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a MB WAY PaymentMethod, this hash contains details about the MB WAY payment
        /// method.
        /// </summary>
        [JsonProperty("mb_way")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mb_way")]
#endif
        public PaymentMethodMbWayOptions MbWay { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>mobilepay</c> PaymentMethod, this hash contains details about the
        /// MobilePay payment method.
        /// </summary>
        [JsonProperty("mobilepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay")]
#endif
        public PaymentMethodMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// If this is a <c>multibanco</c> PaymentMethod, this hash contains details about the
        /// Multibanco payment method.
        /// </summary>
        [JsonProperty("multibanco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco")]
#endif
        public PaymentMethodMultibancoOptions Multibanco { get; set; }

        /// <summary>
        /// If this is a <c>naver_pay</c> PaymentMethod, this hash contains details about the Naver
        /// Pay payment method.
        /// </summary>
        [JsonProperty("naver_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay")]
#endif
        public PaymentMethodNaverPayOptions NaverPay { get; set; }

        /// <summary>
        /// If this is an nz_bank_account PaymentMethod, this hash contains details about the
        /// nz_bank_account payment method.
        /// </summary>
        [JsonProperty("nz_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_bank_account")]
#endif
        public PaymentMethodNzBankAccountOptions NzBankAccount { get; set; }

        /// <summary>
        /// If this is an <c>oxxo</c> PaymentMethod, this hash contains details about the OXXO
        /// payment method.
        /// </summary>
        [JsonProperty("oxxo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo")]
#endif
        public PaymentMethodOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this hash contains details about the P24 payment
        /// method.
        /// </summary>
        [JsonProperty("p24")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24")]
#endif
        public PaymentMethodP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>pay_by_bank</c> PaymentMethod, this hash contains details about the
        /// PayByBank payment method.
        /// </summary>
        [JsonProperty("pay_by_bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank")]
#endif
        public PaymentMethodPayByBankOptions PayByBank { get; set; }

        /// <summary>
        /// If this is a <c>payco</c> PaymentMethod, this hash contains details about the PAYCO
        /// payment method.
        /// </summary>
        [JsonProperty("payco")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco")]
#endif
        public PaymentMethodPaycoOptions Payco { get; set; }

        /// <summary>
        /// The PaymentMethod to share.
        /// </summary>
        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this hash contains details about the PayNow
        /// payment method.
        /// </summary>
        [JsonProperty("paynow")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow")]
#endif
        public PaymentMethodPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this hash contains details about the PayPal
        /// payment method.
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public PaymentMethodPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>paypay</c> PaymentMethod, this hash contains details about the PayPay
        /// payment method.
        /// </summary>
        [JsonProperty("paypay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypay")]
#endif
        public PaymentMethodPaypayOptions Paypay { get; set; }

        /// <summary>
        /// If this is a <c>payto</c> PaymentMethod, this hash contains details about the PayTo
        /// payment method.
        /// </summary>
        [JsonProperty("payto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payto")]
#endif
        public PaymentMethodPaytoOptions Payto { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this hash contains details about the Pix payment
        /// method.
        /// </summary>
        [JsonProperty("pix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix")]
#endif
        public PaymentMethodPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this hash contains details about the
        /// PromptPay payment method.
        /// </summary>
        [JsonProperty("promptpay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay")]
#endif
        public PaymentMethodPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// If this is a <c>qris</c> PaymentMethod, this hash contains details about the QRIS
        /// payment method.
        /// </summary>
        [JsonProperty("qris")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("qris")]
#endif
        public PaymentMethodQrisOptions Qris { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_options")]
#endif
        public PaymentMethodRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// If this is a <c>rechnung</c> PaymentMethod, this hash contains details about the
        /// Rechnung payment method.
        /// </summary>
        [JsonProperty("rechnung")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rechnung")]
#endif
        public PaymentMethodRechnungOptions Rechnung { get; set; }

        /// <summary>
        /// If this is a <c>revolut_pay</c> PaymentMethod, this hash contains details about the
        /// Revolut Pay payment method.
        /// </summary>
        [JsonProperty("revolut_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay")]
#endif
        public PaymentMethodRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// If this is a <c>samsung_pay</c> PaymentMethod, this hash contains details about the
        /// SamsungPay payment method.
        /// </summary>
        [JsonProperty("samsung_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay")]
#endif
        public PaymentMethodSamsungPayOptions SamsungPay { get; set; }

        /// <summary>
        /// If this is a <c>satispay</c> PaymentMethod, this hash contains details about the
        /// Satispay payment method.
        /// </summary>
        [JsonProperty("satispay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("satispay")]
#endif
        public PaymentMethodSatispayOptions Satispay { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentMethod, this hash contains details about the SEPA
        /// debit bank account.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a Shopeepay PaymentMethod, this hash contains details about the Shopeepay
        /// payment method.
        /// </summary>
        [JsonProperty("shopeepay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shopeepay")]
#endif
        public PaymentMethodShopeepayOptions Shopeepay { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this hash contains details about the SOFORT
        /// payment method.
        /// </summary>
        [JsonProperty("sofort")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort")]
#endif
        public PaymentMethodSofortOptions Sofort { get; set; }

        /// <summary>
        /// This hash contains details about the Stripe balance payment method.
        /// </summary>
        [JsonProperty("stripe_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_balance")]
#endif
        public PaymentMethodStripeBalanceOptions StripeBalance { get; set; }

        /// <summary>
        /// If this is a <c>swish</c> PaymentMethod, this hash contains details about the Swish
        /// payment method.
        /// </summary>
        [JsonProperty("swish")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish")]
#endif
        public PaymentMethodSwishOptions Swish { get; set; }

        /// <summary>
        /// If this is a TWINT PaymentMethod, this hash contains details about the TWINT payment
        /// method.
        /// </summary>
        [JsonProperty("twint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint")]
#endif
        public PaymentMethodTwintOptions Twint { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>cashapp</c>, <c>crypto</c>, <c>custom</c>, <c>customer_balance</c>, <c>eps</c>,
        /// <c>fpx</c>, <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>id_bank_transfer</c>,
        /// <c>ideal</c>, <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>,
        /// <c>link</c>, <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>qris</c>, <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>, <c>satispay</c>,
        /// <c>sepa_debit</c>, <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>, <c>swish</c>,
        /// <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// If this is an <c>us_bank_account</c> PaymentMethod, this hash contains details about the
        /// US bank account payment method.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public PaymentMethodUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is an <c>wechat_pay</c> PaymentMethod, this hash contains details about the
        /// wechat_pay payment method.
        /// </summary>
        [JsonProperty("wechat_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("wechat_pay")]
#endif
        public PaymentMethodWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this hash contains details about the Zip payment
        /// method.
        /// </summary>
        [JsonProperty("zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip")]
#endif
        public PaymentMethodZipOptions Zip { get; set; }
    }
}
