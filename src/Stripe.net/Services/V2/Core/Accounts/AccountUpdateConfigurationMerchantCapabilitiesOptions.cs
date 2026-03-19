// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMerchantCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Allow the merchant to process ACH debit payments.
        /// </summary>
        [JsonProperty("ach_debit_payments")]
        [STJS.JsonPropertyName("ach_debit_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAchDebitPaymentsOptions AchDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process ACSS debit payments.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
        [STJS.JsonPropertyName("acss_debit_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Affirm payments.
        /// </summary>
        [JsonProperty("affirm_payments")]
        [STJS.JsonPropertyName("affirm_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Afterpay/Clearpay payments.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Alma payments.
        /// </summary>
        [JsonProperty("alma_payments")]
        [STJS.JsonPropertyName("alma_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAlmaPaymentsOptions AlmaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Amazon Pay payments.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
        [STJS.JsonPropertyName("amazon_pay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAmazonPayPaymentsOptions AmazonPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Australian BECS Direct Debit payments.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        [STJS.JsonPropertyName("au_becs_debit_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BACS Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Bancontact payments.
        /// </summary>
        [JsonProperty("bancontact_payments")]
        [STJS.JsonPropertyName("bancontact_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BLIK payments.
        /// </summary>
        [JsonProperty("blik_payments")]
        [STJS.JsonPropertyName("blik_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Boleto payments.
        /// </summary>
        [JsonProperty("boleto_payments")]
        [STJS.JsonPropertyName("boleto_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to collect card payments.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cartes Bancaires payments.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cash App payments.
        /// </summary>
        [JsonProperty("cashapp_payments")]
        [STJS.JsonPropertyName("cashapp_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesCashappPaymentsOptions CashappPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process EPS payments.
        /// </summary>
        [JsonProperty("eps_payments")]
        [STJS.JsonPropertyName("eps_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process FPX payments.
        /// </summary>
        [JsonProperty("fpx_payments")]
        [STJS.JsonPropertyName("fpx_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process UK bank transfer payments.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesGbBankTransferPaymentsOptions GbBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process GrabPay payments.
        /// </summary>
        [JsonProperty("grabpay_payments")]
        [STJS.JsonPropertyName("grabpay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process iDEAL payments.
        /// </summary>
        [JsonProperty("ideal_payments")]
        [STJS.JsonPropertyName("ideal_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process JCB card payments.
        /// </summary>
        [JsonProperty("jcb_payments")]
        [STJS.JsonPropertyName("jcb_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Japanese bank transfer payments.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesJpBankTransferPaymentsOptions JpBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Kakao Pay payments.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
        [STJS.JsonPropertyName("kakao_pay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesKakaoPayPaymentsOptions KakaoPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Klarna payments.
        /// </summary>
        [JsonProperty("klarna_payments")]
        [STJS.JsonPropertyName("klarna_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Konbini convenience store payments.
        /// </summary>
        [JsonProperty("konbini_payments")]
        [STJS.JsonPropertyName("konbini_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Korean card payments.
        /// </summary>
        [JsonProperty("kr_card_payments")]
        [STJS.JsonPropertyName("kr_card_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesKrCardPaymentsOptions KrCardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Link payments.
        /// </summary>
        [JsonProperty("link_payments")]
        [STJS.JsonPropertyName("link_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process MobilePay payments.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
        [STJS.JsonPropertyName("mobilepay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesMobilepayPaymentsOptions MobilepayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Multibanco payments.
        /// </summary>
        [JsonProperty("multibanco_payments")]
        [STJS.JsonPropertyName("multibanco_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesMultibancoPaymentsOptions MultibancoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Mexican bank transfer payments.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesMxBankTransferPaymentsOptions MxBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Naver Pay payments.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
        [STJS.JsonPropertyName("naver_pay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesNaverPayPaymentsOptions NaverPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process OXXO payments.
        /// </summary>
        [JsonProperty("oxxo_payments")]
        [STJS.JsonPropertyName("oxxo_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Przelewy24 (P24) payments.
        /// </summary>
        [JsonProperty("p24_payments")]
        [STJS.JsonPropertyName("p24_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// Allow the merchant to process Pay by Bank payments.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
        [STJS.JsonPropertyName("pay_by_bank_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesPayByBankPaymentsOptions PayByBankPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PAYCO payments.
        /// </summary>
        [JsonProperty("payco_payments")]
        [STJS.JsonPropertyName("payco_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesPaycoPaymentsOptions PaycoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PayNow payments.
        /// </summary>
        [JsonProperty("paynow_payments")]
        [STJS.JsonPropertyName("paynow_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PromptPay payments.
        /// </summary>
        [JsonProperty("promptpay_payments")]
        [STJS.JsonPropertyName("promptpay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Revolut Pay payments.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
        [STJS.JsonPropertyName("revolut_pay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesRevolutPayPaymentsOptions RevolutPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Samsung Pay payments.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
        [STJS.JsonPropertyName("samsung_pay_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesSamsungPayPaymentsOptions SamsungPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA bank transfer payments.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesSepaBankTransferPaymentsOptions SepaBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        [STJS.JsonPropertyName("sepa_debit_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Swish payments.
        /// </summary>
        [JsonProperty("swish_payments")]
        [STJS.JsonPropertyName("swish_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesSwishPaymentsOptions SwishPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process TWINT payments.
        /// </summary>
        [JsonProperty("twint_payments")]
        [STJS.JsonPropertyName("twint_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesTwintPaymentsOptions TwintPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process US bank transfer payments.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesUsBankTransferPaymentsOptions UsBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Zip payments.
        /// </summary>
        [JsonProperty("zip_payments")]
        [STJS.JsonPropertyName("zip_payments")]
        public AccountUpdateConfigurationMerchantCapabilitiesZipPaymentsOptions ZipPayments { get; set; }
    }
}
