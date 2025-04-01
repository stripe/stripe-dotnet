// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Allow the merchant to process ACH debit payments.
        /// </summary>
        [JsonProperty("ach_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAchDebitPaymentsOptions AchDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process ACSS debit payments.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Affirm payments.
        /// </summary>
        [JsonProperty("affirm_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Afterpay/Clearpay payments.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Alma payments.
        /// </summary>
        [JsonProperty("alma_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAlmaPaymentsOptions AlmaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Amazon Pay payments.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAmazonPayPaymentsOptions AmazonPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Australian BECS Direct Debit payments.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BACS Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Bancontact payments.
        /// </summary>
        [JsonProperty("bancontact_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process BLIK payments.
        /// </summary>
        [JsonProperty("blik_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Boleto payments.
        /// </summary>
        [JsonProperty("boleto_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to collect card payments.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cartes Bancaires payments.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Cash App payments.
        /// </summary>
        [JsonProperty("cashapp_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesCashappPaymentsOptions CashappPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process EPS payments.
        /// </summary>
        [JsonProperty("eps_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process FPX payments.
        /// </summary>
        [JsonProperty("fpx_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process UK bank transfer payments.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesGbBankTransferPaymentsOptions GbBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process GrabPay payments.
        /// </summary>
        [JsonProperty("grabpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process iDEAL payments.
        /// </summary>
        [JsonProperty("ideal_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process JCB card payments.
        /// </summary>
        [JsonProperty("jcb_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jcb_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Japanese bank transfer payments.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesJpBankTransferPaymentsOptions JpBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Kakao Pay payments.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesKakaoPayPaymentsOptions KakaoPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Klarna payments.
        /// </summary>
        [JsonProperty("klarna_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Konbini convenience store payments.
        /// </summary>
        [JsonProperty("konbini_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Korean card payments.
        /// </summary>
        [JsonProperty("kr_card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesKrCardPaymentsOptions KrCardPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Link payments.
        /// </summary>
        [JsonProperty("link_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process MobilePay payments.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesMobilepayPaymentsOptions MobilepayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Multibanco payments.
        /// </summary>
        [JsonProperty("multibanco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesMultibancoPaymentsOptions MultibancoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Mexican bank transfer payments.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesMxBankTransferPaymentsOptions MxBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Naver Pay payments.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesNaverPayPaymentsOptions NaverPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process OXXO payments.
        /// </summary>
        [JsonProperty("oxxo_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Przelewy24 (P24) payments.
        /// </summary>
        [JsonProperty("p24_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// Allow the merchant to process Pay by Bank payments.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesPayByBankPaymentsOptions PayByBankPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PAYCO payments.
        /// </summary>
        [JsonProperty("payco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesPaycoPaymentsOptions PaycoPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PayNow payments.
        /// </summary>
        [JsonProperty("paynow_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process PromptPay payments.
        /// </summary>
        [JsonProperty("promptpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Revolut Pay payments.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesRevolutPayPaymentsOptions RevolutPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Samsung Pay payments.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesSamsungPayPaymentsOptions SamsungPayPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA bank transfer payments.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesSepaBankTransferPaymentsOptions SepaBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Swish payments.
        /// </summary>
        [JsonProperty("swish_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesSwishPaymentsOptions SwishPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process TWINT payments.
        /// </summary>
        [JsonProperty("twint_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesTwintPaymentsOptions TwintPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process US bank transfer payments.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesUsBankTransferPaymentsOptions UsBankTransferPayments { get; set; }

        /// <summary>
        /// Allow the merchant to process Zip payments.
        /// </summary>
        [JsonProperty("zip_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip_payments")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesZipPaymentsOptions ZipPayments { get; set; }
    }
}
