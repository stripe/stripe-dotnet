// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Allow the merchant to process ACH debit payments.
        /// </summary>
        [JsonProperty("ach_debit_payments")]
        [STJS.JsonPropertyName("ach_debit_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAchDebitPaymentsOptions AchDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process ACSS debit payments.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
        [STJS.JsonPropertyName("acss_debit_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Affirm payments.
        /// </summary>
        [JsonProperty("affirm_payments")]
        [STJS.JsonPropertyName("affirm_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Afterpay/Clearpay payments.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Alma payments.
        /// </summary>
        [JsonProperty("alma_payments")]
        [STJS.JsonPropertyName("alma_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAlmaPaymentsOptions AlmaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Amazon Pay payments.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
        [STJS.JsonPropertyName("amazon_pay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAmazonPayPaymentsOptions AmazonPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Australian BECS Direct Debit payments.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        [STJS.JsonPropertyName("au_becs_debit_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BACS Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Bancontact payments.
        /// </summary>
        [JsonProperty("bancontact_payments")]
        [STJS.JsonPropertyName("bancontact_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BLIK payments.
        /// </summary>
        [JsonProperty("blik_payments")]
        [STJS.JsonPropertyName("blik_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Boleto payments.
        /// </summary>
        [JsonProperty("boleto_payments")]
        [STJS.JsonPropertyName("boleto_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to collect card payments.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cartes Bancaires payments.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cash App payments.
        /// </summary>
        [JsonProperty("cashapp_payments")]
        [STJS.JsonPropertyName("cashapp_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesCashappPaymentsOptions CashappPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process EPS payments.
        /// </summary>
        [JsonProperty("eps_payments")]
        [STJS.JsonPropertyName("eps_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process FPX payments.
        /// </summary>
        [JsonProperty("fpx_payments")]
        [STJS.JsonPropertyName("fpx_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process UK bank transfer payments.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesGbBankTransferPaymentsOptions GbBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process GrabPay payments.
        /// </summary>
        [JsonProperty("grabpay_payments")]
        [STJS.JsonPropertyName("grabpay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process iDEAL payments.
        /// </summary>
        [JsonProperty("ideal_payments")]
        [STJS.JsonPropertyName("ideal_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process JCB card payments.
        /// </summary>
        [JsonProperty("jcb_payments")]
        [STJS.JsonPropertyName("jcb_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Japanese bank transfer payments.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesJpBankTransferPaymentsOptions JpBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Kakao Pay payments.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
        [STJS.JsonPropertyName("kakao_pay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesKakaoPayPaymentsOptions KakaoPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Klarna payments.
        /// </summary>
        [JsonProperty("klarna_payments")]
        [STJS.JsonPropertyName("klarna_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Konbini convenience store payments.
        /// </summary>
        [JsonProperty("konbini_payments")]
        [STJS.JsonPropertyName("konbini_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Korean card payments.
        /// </summary>
        [JsonProperty("kr_card_payments")]
        [STJS.JsonPropertyName("kr_card_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesKrCardPaymentsOptions KrCardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Link payments.
        /// </summary>
        [JsonProperty("link_payments")]
        [STJS.JsonPropertyName("link_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process MobilePay payments.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
        [STJS.JsonPropertyName("mobilepay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesMobilepayPaymentsOptions MobilepayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Multibanco payments.
        /// </summary>
        [JsonProperty("multibanco_payments")]
        [STJS.JsonPropertyName("multibanco_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesMultibancoPaymentsOptions MultibancoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Mexican bank transfer payments.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesMxBankTransferPaymentsOptions MxBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Naver Pay payments.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
        [STJS.JsonPropertyName("naver_pay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesNaverPayPaymentsOptions NaverPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process OXXO payments.
        /// </summary>
        [JsonProperty("oxxo_payments")]
        [STJS.JsonPropertyName("oxxo_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Przelewy24 (P24) payments.
        /// </summary>
        [JsonProperty("p24_payments")]
        [STJS.JsonPropertyName("p24_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// Allow the merchant to process Pay by Bank payments.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
        [STJS.JsonPropertyName("pay_by_bank_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesPayByBankPaymentsOptions PayByBankPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PAYCO payments.
        /// </summary>
        [JsonProperty("payco_payments")]
        [STJS.JsonPropertyName("payco_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesPaycoPaymentsOptions PaycoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PayNow payments.
        /// </summary>
        [JsonProperty("paynow_payments")]
        [STJS.JsonPropertyName("paynow_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PromptPay payments.
        /// </summary>
        [JsonProperty("promptpay_payments")]
        [STJS.JsonPropertyName("promptpay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Revolut Pay payments.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
        [STJS.JsonPropertyName("revolut_pay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesRevolutPayPaymentsOptions RevolutPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Samsung Pay payments.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
        [STJS.JsonPropertyName("samsung_pay_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesSamsungPayPaymentsOptions SamsungPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA bank transfer payments.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesSepaBankTransferPaymentsOptions SepaBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        [STJS.JsonPropertyName("sepa_debit_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Swish payments.
        /// </summary>
        [JsonProperty("swish_payments")]
        [STJS.JsonPropertyName("swish_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesSwishPaymentsOptions SwishPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process TWINT payments.
        /// </summary>
        [JsonProperty("twint_payments")]
        [STJS.JsonPropertyName("twint_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesTwintPaymentsOptions TwintPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process US bank transfer payments.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesUsBankTransferPaymentsOptions UsBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Zip payments.
        /// </summary>
        [JsonProperty("zip_payments")]
        [STJS.JsonPropertyName("zip_payments")]
        public AccountCreateConfigurationMerchantCapabilitiesZipPaymentsOptions ZipPayments { get; set; }
    }
}
