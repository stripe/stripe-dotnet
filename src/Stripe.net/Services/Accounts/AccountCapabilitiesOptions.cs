// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// The acss_debit_payments capability.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit_payments")]
#endif
        public AccountCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// The affirm_payments capability.
        /// </summary>
        [JsonProperty("affirm_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm_payments")]
#endif
        public AccountCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// The afterpay_clearpay_payments capability.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
#endif
        public AccountCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The alma_payments capability.
        /// </summary>
        [JsonProperty("alma_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma_payments")]
#endif
        public AccountCapabilitiesAlmaPaymentsOptions AlmaPayments { get; set; }

        /// <summary>
        /// The amazon_pay_payments capability.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay_payments")]
#endif
        public AccountCapabilitiesAmazonPayPaymentsOptions AmazonPayPayments { get; set; }

        /// <summary>
        /// The au_becs_debit_payments capability.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit_payments")]
#endif
        public AccountCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The bacs_debit_payments capability.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// The bancontact_payments capability.
        /// </summary>
        [JsonProperty("bancontact_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact_payments")]
#endif
        public AccountCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// The bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer_payments")]
#endif
        public AccountCapabilitiesBankTransferPaymentsOptions BankTransferPayments { get; set; }

        /// <summary>
        /// The blik_payments capability.
        /// </summary>
        [JsonProperty("blik_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik_payments")]
#endif
        public AccountCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// The boleto_payments capability.
        /// </summary>
        [JsonProperty("boleto_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto_payments")]
#endif
        public AccountCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// The card_issuing capability.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public AccountCapabilitiesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// The card_payments capability.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// The cartes_bancaires_payments capability.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
#endif
        public AccountCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// The cashapp_payments capability.
        /// </summary>
        [JsonProperty("cashapp_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp_payments")]
#endif
        public AccountCapabilitiesCashappPaymentsOptions CashappPayments { get; set; }

        /// <summary>
        /// The eps_payments capability.
        /// </summary>
        [JsonProperty("eps_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps_payments")]
#endif
        public AccountCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// The fpx_payments capability.
        /// </summary>
        [JsonProperty("fpx_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx_payments")]
#endif
        public AccountCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// The gb_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
#endif
        public AccountCapabilitiesGbBankTransferPaymentsOptions GbBankTransferPayments { get; set; }

        /// <summary>
        /// The giropay_payments capability.
        /// </summary>
        [JsonProperty("giropay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay_payments")]
#endif
        public AccountCapabilitiesGiropayPaymentsOptions GiropayPayments { get; set; }

        /// <summary>
        /// The grabpay_payments capability.
        /// </summary>
        [JsonProperty("grabpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay_payments")]
#endif
        public AccountCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// The ideal_payments capability.
        /// </summary>
        [JsonProperty("ideal_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal_payments")]
#endif
        public AccountCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// The india_international_payments capability.
        /// </summary>
        [JsonProperty("india_international_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("india_international_payments")]
#endif
        public AccountCapabilitiesIndiaInternationalPaymentsOptions IndiaInternationalPayments { get; set; }

        /// <summary>
        /// The jcb_payments capability.
        /// </summary>
        [JsonProperty("jcb_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jcb_payments")]
#endif
        public AccountCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// The jp_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
#endif
        public AccountCapabilitiesJpBankTransferPaymentsOptions JpBankTransferPayments { get; set; }

        /// <summary>
        /// The kakao_pay_payments capability.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay_payments")]
#endif
        public AccountCapabilitiesKakaoPayPaymentsOptions KakaoPayPayments { get; set; }

        /// <summary>
        /// The klarna_payments capability.
        /// </summary>
        [JsonProperty("klarna_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna_payments")]
#endif
        public AccountCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// The konbini_payments capability.
        /// </summary>
        [JsonProperty("konbini_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_payments")]
#endif
        public AccountCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// The kr_card_payments capability.
        /// </summary>
        [JsonProperty("kr_card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card_payments")]
#endif
        public AccountCapabilitiesKrCardPaymentsOptions KrCardPayments { get; set; }

        /// <summary>
        /// The legacy_payments capability.
        /// </summary>
        [JsonProperty("legacy_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legacy_payments")]
#endif
        public AccountCapabilitiesLegacyPaymentsOptions LegacyPayments { get; set; }

        /// <summary>
        /// The link_payments capability.
        /// </summary>
        [JsonProperty("link_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_payments")]
#endif
        public AccountCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// The mobilepay_payments capability.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay_payments")]
#endif
        public AccountCapabilitiesMobilepayPaymentsOptions MobilepayPayments { get; set; }

        /// <summary>
        /// The multibanco_payments capability.
        /// </summary>
        [JsonProperty("multibanco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco_payments")]
#endif
        public AccountCapabilitiesMultibancoPaymentsOptions MultibancoPayments { get; set; }

        /// <summary>
        /// The mx_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
#endif
        public AccountCapabilitiesMxBankTransferPaymentsOptions MxBankTransferPayments { get; set; }

        /// <summary>
        /// The naver_pay_payments capability.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay_payments")]
#endif
        public AccountCapabilitiesNaverPayPaymentsOptions NaverPayPayments { get; set; }

        /// <summary>
        /// The oxxo_payments capability.
        /// </summary>
        [JsonProperty("oxxo_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo_payments")]
#endif
        public AccountCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// The p24_payments capability.
        /// </summary>
        [JsonProperty("p24_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24_payments")]
#endif
        public AccountCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// The pay_by_bank_payments capability.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank_payments")]
#endif
        public AccountCapabilitiesPayByBankPaymentsOptions PayByBankPayments { get; set; }

        /// <summary>
        /// The payco_payments capability.
        /// </summary>
        [JsonProperty("payco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco_payments")]
#endif
        public AccountCapabilitiesPaycoPaymentsOptions PaycoPayments { get; set; }

        /// <summary>
        /// The paynow_payments capability.
        /// </summary>
        [JsonProperty("paynow_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow_payments")]
#endif
        public AccountCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// The promptpay_payments capability.
        /// </summary>
        [JsonProperty("promptpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay_payments")]
#endif
        public AccountCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// The revolut_pay_payments capability.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay_payments")]
#endif
        public AccountCapabilitiesRevolutPayPaymentsOptions RevolutPayPayments { get; set; }

        /// <summary>
        /// The samsung_pay_payments capability.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay_payments")]
#endif
        public AccountCapabilitiesSamsungPayPaymentsOptions SamsungPayPayments { get; set; }

        /// <summary>
        /// The sepa_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
#endif
        public AccountCapabilitiesSepaBankTransferPaymentsOptions SepaBankTransferPayments { get; set; }

        /// <summary>
        /// The sepa_debit_payments capability.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit_payments")]
#endif
        public AccountCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// The sofort_payments capability.
        /// </summary>
        [JsonProperty("sofort_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort_payments")]
#endif
        public AccountCapabilitiesSofortPaymentsOptions SofortPayments { get; set; }

        /// <summary>
        /// The swish_payments capability.
        /// </summary>
        [JsonProperty("swish_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish_payments")]
#endif
        public AccountCapabilitiesSwishPaymentsOptions SwishPayments { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_k capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_reporting_us_1099_k")]
#endif
        public AccountCapabilitiesTaxReportingUs1099KOptions TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_misc capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_reporting_us_1099_misc")]
#endif
        public AccountCapabilitiesTaxReportingUs1099MiscOptions TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The transfers capability.
        /// </summary>
        [JsonProperty("transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfers")]
#endif
        public AccountCapabilitiesTransfersOptions Transfers { get; set; }

        /// <summary>
        /// The treasury capability.
        /// </summary>
        [JsonProperty("treasury")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury")]
#endif
        public AccountCapabilitiesTreasuryOptions Treasury { get; set; }

        /// <summary>
        /// The twint_payments capability.
        /// </summary>
        [JsonProperty("twint_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint_payments")]
#endif
        public AccountCapabilitiesTwintPaymentsOptions TwintPayments { get; set; }

        /// <summary>
        /// The us_bank_account_ach_payments capability.
        /// </summary>
        [JsonProperty("us_bank_account_ach_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account_ach_payments")]
#endif
        public AccountCapabilitiesUsBankAccountAchPaymentsOptions UsBankAccountAchPayments { get; set; }

        /// <summary>
        /// The us_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
#endif
        public AccountCapabilitiesUsBankTransferPaymentsOptions UsBankTransferPayments { get; set; }

        /// <summary>
        /// The zip_payments capability.
        /// </summary>
        [JsonProperty("zip_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip_payments")]
#endif
        public AccountCapabilitiesZipPaymentsOptions ZipPayments { get; set; }
    }
}
