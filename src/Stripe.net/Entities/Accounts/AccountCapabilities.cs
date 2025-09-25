// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the Canadian pre-authorized debits payments capability of the account, or
        /// whether the account can directly process Canadian pre-authorized debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit_payments")]
#endif
        public string AcssDebitPayments { get; set; }

        /// <summary>
        /// The status of the Affirm capability of the account, or whether the account can directly
        /// process Affirm charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("affirm_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affirm_payments")]
#endif
        public string AffirmPayments { get; set; }

        /// <summary>
        /// The status of the Afterpay Clearpay capability of the account, or whether the account
        /// can directly process Afterpay Clearpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
#endif
        public string AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The status of the Alma capability of the account, or whether the account can directly
        /// process Alma payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("alma_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alma_payments")]
#endif
        public string AlmaPayments { get; set; }

        /// <summary>
        /// The status of the AmazonPay capability of the account, or whether the account can
        /// directly process AmazonPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay_payments")]
#endif
        public string AmazonPayPayments { get; set; }

        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("au_becs_debit_payments")]
#endif
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bacs Direct Debits payments capability of the account, or whether the
        /// account can directly process Bacs Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public string BacsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bancontact payments capability of the account, or whether the account
        /// can directly process Bancontact charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bancontact_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact_payments")]
#endif
        public string BancontactPayments { get; set; }

        /// <summary>
        /// The status of the customer_balance payments capability of the account, or whether the
        /// account can directly process customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_transfer_payments")]
#endif
        public string BankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Billie capability of the account, or whether the account can directly
        /// process Billie payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("billie_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billie_payments")]
#endif
        public string BilliePayments { get; set; }

        /// <summary>
        /// The status of the blik payments capability of the account, or whether the account can
        /// directly process blik charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("blik_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blik_payments")]
#endif
        public string BlikPayments { get; set; }

        /// <summary>
        /// The status of the boleto payments capability of the account, or whether the account can
        /// directly process boleto charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("boleto_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("boleto_payments")]
#endif
        public string BoletoPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the Cartes Bancaires payments capability of the account, or whether the
        /// account can directly process Cartes Bancaires card charges in EUR currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
#endif
        public string CartesBancairesPayments { get; set; }

        /// <summary>
        /// The status of the Cash App Pay capability of the account, or whether the account can
        /// directly process Cash App Pay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("cashapp_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cashapp_payments")]
#endif
        public string CashappPayments { get; set; }

        /// <summary>
        /// The status of the Crypto capability of the account, or whether the account can directly
        /// process Crypto payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("crypto_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("crypto_payments")]
#endif
        public string CryptoPayments { get; set; }

        /// <summary>
        /// The status of the EPS payments capability of the account, or whether the account can
        /// directly process EPS charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("eps_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eps_payments")]
#endif
        public string EpsPayments { get; set; }

        /// <summary>
        /// The status of the FPX payments capability of the account, or whether the account can
        /// directly process FPX charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("fpx_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fpx_payments")]
#endif
        public string FpxPayments { get; set; }

        /// <summary>
        /// The status of the GB customer_balance payments (GBP currency) capability of the account,
        /// or whether the account can directly process GB customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
#endif
        public string GbBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the giropay payments capability of the account, or whether the account can
        /// directly process giropay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("giropay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("giropay_payments")]
#endif
        public string GiropayPayments { get; set; }

        /// <summary>
        /// The status of the GrabPay payments capability of the account, or whether the account can
        /// directly process GrabPay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("grabpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("grabpay_payments")]
#endif
        public string GrabpayPayments { get; set; }

        /// <summary>
        /// The status of the iDEAL payments capability of the account, or whether the account can
        /// directly process iDEAL charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("ideal_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ideal_payments")]
#endif
        public string IdealPayments { get; set; }

        /// <summary>
        /// The status of the india_international_payments capability of the account, or whether the
        /// account can process international charges (non INR) in India.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("india_international_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("india_international_payments")]
#endif
        public string IndiaInternationalPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("jcb_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jcb_payments")]
#endif
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the Japanese customer_balance payments (JPY currency) capability of the
        /// account, or whether the account can directly process Japanese customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
#endif
        public string JpBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the KakaoPay capability of the account, or whether the account can
        /// directly process KakaoPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kakao_pay_payments")]
#endif
        public string KakaoPayPayments { get; set; }

        /// <summary>
        /// The status of the Klarna payments capability of the account, or whether the account can
        /// directly process Klarna charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("klarna_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("klarna_payments")]
#endif
        public string KlarnaPayments { get; set; }

        /// <summary>
        /// The status of the konbini payments capability of the account, or whether the account can
        /// directly process konbini charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("konbini_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_payments")]
#endif
        public string KonbiniPayments { get; set; }

        /// <summary>
        /// The status of the KrCard capability of the account, or whether the account can directly
        /// process KrCard payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("kr_card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("kr_card_payments")]
#endif
        public string KrCardPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("legacy_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legacy_payments")]
#endif
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the link_payments capability of the account, or whether the account can
        /// directly process Link charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("link_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link_payments")]
#endif
        public string LinkPayments { get; set; }

        /// <summary>
        /// The status of the MB WAY payments capability of the account, or whether the account can
        /// directly process MB WAY charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mb_way_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mb_way_payments")]
#endif
        public string MbWayPayments { get; set; }

        /// <summary>
        /// The status of the MobilePay capability of the account, or whether the account can
        /// directly process MobilePay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobilepay_payments")]
#endif
        public string MobilepayPayments { get; set; }

        /// <summary>
        /// The status of the Multibanco payments capability of the account, or whether the account
        /// can directly process Multibanco charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("multibanco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multibanco_payments")]
#endif
        public string MultibancoPayments { get; set; }

        /// <summary>
        /// The status of the Mexican customer_balance payments (MXN currency) capability of the
        /// account, or whether the account can directly process Mexican customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
#endif
        public string MxBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the NaverPay capability of the account, or whether the account can
        /// directly process NaverPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("naver_pay_payments")]
#endif
        public string NaverPayPayments { get; set; }

        /// <summary>
        /// The status of the New Zealand BECS Direct Debit payments capability of the account, or
        /// whether the account can directly process New Zealand BECS Direct Debit charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("nz_bank_account_becs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nz_bank_account_becs_debit_payments")]
#endif
        public string NzBankAccountBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the OXXO payments capability of the account, or whether the account can
        /// directly process OXXO charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("oxxo_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("oxxo_payments")]
#endif
        public string OxxoPayments { get; set; }

        /// <summary>
        /// The status of the P24 payments capability of the account, or whether the account can
        /// directly process P24 charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("p24_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("p24_payments")]
#endif
        public string P24Payments { get; set; }

        /// <summary>
        /// The status of the pay_by_bank payments capability of the account, or whether the account
        /// can directly process pay_by_bank charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pay_by_bank_payments")]
#endif
        public string PayByBankPayments { get; set; }

        /// <summary>
        /// The status of the Payco capability of the account, or whether the account can directly
        /// process Payco payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("payco_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payco_payments")]
#endif
        public string PaycoPayments { get; set; }

        /// <summary>
        /// The status of the paynow payments capability of the account, or whether the account can
        /// directly process paynow charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("paynow_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paynow_payments")]
#endif
        public string PaynowPayments { get; set; }

        /// <summary>
        /// The status of the pix payments capability of the account, or whether the account can
        /// directly process pix charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("pix_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pix_payments")]
#endif
        public string PixPayments { get; set; }

        /// <summary>
        /// The status of the promptpay payments capability of the account, or whether the account
        /// can directly process promptpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("promptpay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("promptpay_payments")]
#endif
        public string PromptpayPayments { get; set; }

        /// <summary>
        /// The status of the RevolutPay capability of the account, or whether the account can
        /// directly process RevolutPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("revolut_pay_payments")]
#endif
        public string RevolutPayPayments { get; set; }

        /// <summary>
        /// The status of the SamsungPay capability of the account, or whether the account can
        /// directly process SamsungPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("samsung_pay_payments")]
#endif
        public string SamsungPayPayments { get; set; }

        /// <summary>
        /// The status of the Satispay capability of the account, or whether the account can
        /// directly process Satispay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("satispay_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("satispay_payments")]
#endif
        public string SatispayPayments { get; set; }

        /// <summary>
        /// The status of the SEPA customer_balance payments (EUR currency) capability of the
        /// account, or whether the account can directly process SEPA customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
#endif
        public string SepaBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the SEPA Direct Debits payments capability of the account, or whether the
        /// account can directly process SEPA Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit_payments")]
#endif
        public string SepaDebitPayments { get; set; }

        /// <summary>
        /// The status of the Sofort payments capability of the account, or whether the account can
        /// directly process Sofort charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sofort_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sofort_payments")]
#endif
        public string SofortPayments { get; set; }

        /// <summary>
        /// The status of the Swish capability of the account, or whether the account can directly
        /// process Swish payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("swish_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swish_payments")]
#endif
        public string SwishPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_reporting_us_1099_k")]
#endif
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_reporting_us_1099_misc")]
#endif
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfers")]
#endif
        public string Transfers { get; set; }

        /// <summary>
        /// The status of the banking capability, or whether the account can have bank accounts.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("treasury")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("treasury")]
#endif
        public string Treasury { get; set; }

        /// <summary>
        /// The status of the TWINT capability of the account, or whether the account can directly
        /// process TWINT charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("twint_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("twint_payments")]
#endif
        public string TwintPayments { get; set; }

        /// <summary>
        /// The status of the US bank account ACH payments capability of the account, or whether the
        /// account can directly process US bank account charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("us_bank_account_ach_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account_ach_payments")]
#endif
        public string UsBankAccountAchPayments { get; set; }

        /// <summary>
        /// The status of the US customer_balance payments (USD currency) capability of the account,
        /// or whether the account can directly process US customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
#endif
        public string UsBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Zip capability of the account, or whether the account can directly
        /// process Zip charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("zip_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("zip_payments")]
#endif
        public string ZipPayments { get; set; }
    }
}
