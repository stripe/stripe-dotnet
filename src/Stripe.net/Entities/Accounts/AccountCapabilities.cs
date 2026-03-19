// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the Canadian pre-authorized debits payments capability of the account, or
        /// whether the account can directly process Canadian pre-authorized debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
        [STJS.JsonPropertyName("acss_debit_payments")]
        public string AcssDebitPayments { get; set; }

        /// <summary>
        /// The status of the Affirm capability of the account, or whether the account can directly
        /// process Affirm charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("affirm_payments")]
        [STJS.JsonPropertyName("affirm_payments")]
        public string AffirmPayments { get; set; }

        /// <summary>
        /// The status of the Afterpay Clearpay capability of the account, or whether the account
        /// can directly process Afterpay Clearpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
        [STJS.JsonPropertyName("afterpay_clearpay_payments")]
        public string AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The status of the Alma capability of the account, or whether the account can directly
        /// process Alma payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("alma_payments")]
        [STJS.JsonPropertyName("alma_payments")]
        public string AlmaPayments { get; set; }

        /// <summary>
        /// The status of the AmazonPay capability of the account, or whether the account can
        /// directly process AmazonPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
        [STJS.JsonPropertyName("amazon_pay_payments")]
        public string AmazonPayPayments { get; set; }

        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        [STJS.JsonPropertyName("au_becs_debit_payments")]
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the automatic_indirect_tax capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
        [STJS.JsonPropertyName("automatic_indirect_tax")]
        public string AutomaticIndirectTax { get; set; }

        /// <summary>
        /// The status of the Bacs Direct Debits payments capability of the account, or whether the
        /// account can directly process Bacs Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public string BacsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bancontact payments capability of the account, or whether the account
        /// can directly process Bancontact charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bancontact_payments")]
        [STJS.JsonPropertyName("bancontact_payments")]
        public string BancontactPayments { get; set; }

        /// <summary>
        /// The status of the customer_balance payments capability of the account, or whether the
        /// account can directly process customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bank_transfer_payments")]
        [STJS.JsonPropertyName("bank_transfer_payments")]
        public string BankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Billie capability of the account, or whether the account can directly
        /// process Billie payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("billie_payments")]
        [STJS.JsonPropertyName("billie_payments")]
        public string BilliePayments { get; set; }

        /// <summary>
        /// The status of the blik payments capability of the account, or whether the account can
        /// directly process blik charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("blik_payments")]
        [STJS.JsonPropertyName("blik_payments")]
        public string BlikPayments { get; set; }

        /// <summary>
        /// The status of the boleto payments capability of the account, or whether the account can
        /// directly process boleto charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("boleto_payments")]
        [STJS.JsonPropertyName("boleto_payments")]
        public string BoletoPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_issuing")]
        [STJS.JsonPropertyName("card_issuing")]
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the Cartes Bancaires payments capability of the account, or whether the
        /// account can directly process Cartes Bancaires card charges in EUR currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        [STJS.JsonPropertyName("cartes_bancaires_payments")]
        public string CartesBancairesPayments { get; set; }

        /// <summary>
        /// The status of the Cash App Pay capability of the account, or whether the account can
        /// directly process Cash App Pay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("cashapp_payments")]
        [STJS.JsonPropertyName("cashapp_payments")]
        public string CashappPayments { get; set; }

        /// <summary>
        /// The status of the Crypto capability of the account, or whether the account can directly
        /// process Crypto payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("crypto_payments")]
        [STJS.JsonPropertyName("crypto_payments")]
        public string CryptoPayments { get; set; }

        /// <summary>
        /// The status of the EPS payments capability of the account, or whether the account can
        /// directly process EPS charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("eps_payments")]
        [STJS.JsonPropertyName("eps_payments")]
        public string EpsPayments { get; set; }

        /// <summary>
        /// The status of the FPX payments capability of the account, or whether the account can
        /// directly process FPX charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("fpx_payments")]
        [STJS.JsonPropertyName("fpx_payments")]
        public string FpxPayments { get; set; }

        /// <summary>
        /// The status of the GB customer_balance payments (GBP currency) capability of the account,
        /// or whether the account can directly process GB customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
        [STJS.JsonPropertyName("gb_bank_transfer_payments")]
        public string GbBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the giropay payments capability of the account, or whether the account can
        /// directly process giropay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("giropay_payments")]
        [STJS.JsonPropertyName("giropay_payments")]
        public string GiropayPayments { get; set; }

        /// <summary>
        /// The status of the Gopay capability of the account, or whether the account can directly
        /// process Gopay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("gopay_payments")]
        [STJS.JsonPropertyName("gopay_payments")]
        public string GopayPayments { get; set; }

        /// <summary>
        /// The status of the GrabPay payments capability of the account, or whether the account can
        /// directly process GrabPay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("grabpay_payments")]
        [STJS.JsonPropertyName("grabpay_payments")]
        public string GrabpayPayments { get; set; }

        /// <summary>
        /// The status of the Indonesia Bank Transfer payments capability of the account, or whether
        /// the account can directly process Indonesia Bank Transfer charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("id_bank_transfer_payments")]
        [STJS.JsonPropertyName("id_bank_transfer_payments")]
        public string IdBankTransferPayments { get; set; }

        /// <summary>
        /// The status of Bank BCA onboarding of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("id_bank_transfer_payments_bca")]
        [STJS.JsonPropertyName("id_bank_transfer_payments_bca")]
        public string IdBankTransferPaymentsBca { get; set; }

        /// <summary>
        /// The status of the iDEAL payments capability of the account, or whether the account can
        /// directly process iDEAL charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("ideal_payments")]
        [STJS.JsonPropertyName("ideal_payments")]
        public string IdealPayments { get; set; }

        /// <summary>
        /// The status of the india_international_payments capability of the account, or whether the
        /// account can process international charges (non INR) in India.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("india_international_payments")]
        [STJS.JsonPropertyName("india_international_payments")]
        public string IndiaInternationalPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("jcb_payments")]
        [STJS.JsonPropertyName("jcb_payments")]
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the Japanese customer_balance payments (JPY currency) capability of the
        /// account, or whether the account can directly process Japanese customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
        [STJS.JsonPropertyName("jp_bank_transfer_payments")]
        public string JpBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the KakaoPay capability of the account, or whether the account can
        /// directly process KakaoPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
        [STJS.JsonPropertyName("kakao_pay_payments")]
        public string KakaoPayPayments { get; set; }

        /// <summary>
        /// The status of the Klarna payments capability of the account, or whether the account can
        /// directly process Klarna charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("klarna_payments")]
        [STJS.JsonPropertyName("klarna_payments")]
        public string KlarnaPayments { get; set; }

        /// <summary>
        /// The status of the konbini payments capability of the account, or whether the account can
        /// directly process konbini charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("konbini_payments")]
        [STJS.JsonPropertyName("konbini_payments")]
        public string KonbiniPayments { get; set; }

        /// <summary>
        /// The status of the KrCard capability of the account, or whether the account can directly
        /// process KrCard payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("kr_card_payments")]
        [STJS.JsonPropertyName("kr_card_payments")]
        public string KrCardPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("legacy_payments")]
        [STJS.JsonPropertyName("legacy_payments")]
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the link_payments capability of the account, or whether the account can
        /// directly process Link charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("link_payments")]
        [STJS.JsonPropertyName("link_payments")]
        public string LinkPayments { get; set; }

        /// <summary>
        /// The status of the MB WAY payments capability of the account, or whether the account can
        /// directly process MB WAY charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mb_way_payments")]
        [STJS.JsonPropertyName("mb_way_payments")]
        public string MbWayPayments { get; set; }

        /// <summary>
        /// The status of the MobilePay capability of the account, or whether the account can
        /// directly process MobilePay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
        [STJS.JsonPropertyName("mobilepay_payments")]
        public string MobilepayPayments { get; set; }

        /// <summary>
        /// The status of the Multibanco payments capability of the account, or whether the account
        /// can directly process Multibanco charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("multibanco_payments")]
        [STJS.JsonPropertyName("multibanco_payments")]
        public string MultibancoPayments { get; set; }

        /// <summary>
        /// The status of the Mexican customer_balance payments (MXN currency) capability of the
        /// account, or whether the account can directly process Mexican customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
        [STJS.JsonPropertyName("mx_bank_transfer_payments")]
        public string MxBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the NaverPay capability of the account, or whether the account can
        /// directly process NaverPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
        [STJS.JsonPropertyName("naver_pay_payments")]
        public string NaverPayPayments { get; set; }

        /// <summary>
        /// The status of the New Zealand BECS Direct Debit payments capability of the account, or
        /// whether the account can directly process New Zealand BECS Direct Debit charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("nz_bank_account_becs_debit_payments")]
        [STJS.JsonPropertyName("nz_bank_account_becs_debit_payments")]
        public string NzBankAccountBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the OXXO payments capability of the account, or whether the account can
        /// directly process OXXO charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("oxxo_payments")]
        [STJS.JsonPropertyName("oxxo_payments")]
        public string OxxoPayments { get; set; }

        /// <summary>
        /// The status of the P24 payments capability of the account, or whether the account can
        /// directly process P24 charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("p24_payments")]
        [STJS.JsonPropertyName("p24_payments")]
        public string P24Payments { get; set; }

        /// <summary>
        /// The status of the pay_by_bank payments capability of the account, or whether the account
        /// can directly process pay_by_bank charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
        [STJS.JsonPropertyName("pay_by_bank_payments")]
        public string PayByBankPayments { get; set; }

        /// <summary>
        /// The status of the Payco capability of the account, or whether the account can directly
        /// process Payco payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("payco_payments")]
        [STJS.JsonPropertyName("payco_payments")]
        public string PaycoPayments { get; set; }

        /// <summary>
        /// The status of the paynow payments capability of the account, or whether the account can
        /// directly process paynow charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("paynow_payments")]
        [STJS.JsonPropertyName("paynow_payments")]
        public string PaynowPayments { get; set; }

        /// <summary>
        /// The status of the PayPal payments capability of the account, or whether the account can
        /// directly process PayPal charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("paypal_payments")]
        [STJS.JsonPropertyName("paypal_payments")]
        public string PaypalPayments { get; set; }

        /// <summary>
        /// The status of the Paypay capability of the account, or whether the account can directly
        /// process Paypay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("paypay_payments")]
        [STJS.JsonPropertyName("paypay_payments")]
        public string PaypayPayments { get; set; }

        /// <summary>
        /// The status of the PayTo capability of the account, or whether the account can directly
        /// process PayTo charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("payto_payments")]
        [STJS.JsonPropertyName("payto_payments")]
        public string PaytoPayments { get; set; }

        /// <summary>
        /// The status of the pix payments capability of the account, or whether the account can
        /// directly process pix charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("pix_payments")]
        [STJS.JsonPropertyName("pix_payments")]
        public string PixPayments { get; set; }

        /// <summary>
        /// The status of the promptpay payments capability of the account, or whether the account
        /// can directly process promptpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("promptpay_payments")]
        [STJS.JsonPropertyName("promptpay_payments")]
        public string PromptpayPayments { get; set; }

        /// <summary>
        /// The status of the Qris capability of the account, or whether the account can directly
        /// process Qris payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("qris_payments")]
        [STJS.JsonPropertyName("qris_payments")]
        public string QrisPayments { get; set; }

        /// <summary>
        /// The status of the Rechnung capability of the account, or whether the account can
        /// directly process Rechnung payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("rechnung_payments")]
        [STJS.JsonPropertyName("rechnung_payments")]
        public string RechnungPayments { get; set; }

        /// <summary>
        /// The status of the RevolutPay capability of the account, or whether the account can
        /// directly process RevolutPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
        [STJS.JsonPropertyName("revolut_pay_payments")]
        public string RevolutPayPayments { get; set; }

        /// <summary>
        /// The status of the SamsungPay capability of the account, or whether the account can
        /// directly process SamsungPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
        [STJS.JsonPropertyName("samsung_pay_payments")]
        public string SamsungPayPayments { get; set; }

        /// <summary>
        /// The status of the Satispay capability of the account, or whether the account can
        /// directly process Satispay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("satispay_payments")]
        [STJS.JsonPropertyName("satispay_payments")]
        public string SatispayPayments { get; set; }

        /// <summary>
        /// The status of the SEPA customer_balance payments (EUR currency) capability of the
        /// account, or whether the account can directly process SEPA customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
        [STJS.JsonPropertyName("sepa_bank_transfer_payments")]
        public string SepaBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the SEPA Direct Debits payments capability of the account, or whether the
        /// account can directly process SEPA Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        [STJS.JsonPropertyName("sepa_debit_payments")]
        public string SepaDebitPayments { get; set; }

        /// <summary>
        /// The status of the ShopeePay capability of the account, or whether the account can
        /// directly process ShopeePay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("shopeepay_payments")]
        [STJS.JsonPropertyName("shopeepay_payments")]
        public string ShopeepayPayments { get; set; }

        /// <summary>
        /// The status of the Sofort payments capability of the account, or whether the account can
        /// directly process Sofort charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sofort_payments")]
        [STJS.JsonPropertyName("sofort_payments")]
        public string SofortPayments { get; set; }

        /// <summary>
        /// The status of the stripe_balance payments capability of the account, or whether the
        /// account can directly process stripe_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("stripe_balance_payments")]
        [STJS.JsonPropertyName("stripe_balance_payments")]
        public string StripeBalancePayments { get; set; }

        /// <summary>
        /// The status of the Swish capability of the account, or whether the account can directly
        /// process Swish payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("swish_payments")]
        [STJS.JsonPropertyName("swish_payments")]
        public string SwishPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
        [STJS.JsonPropertyName("tax_reporting_us_1099_k")]
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
        [STJS.JsonPropertyName("tax_reporting_us_1099_misc")]
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("transfers")]
        [STJS.JsonPropertyName("transfers")]
        public string Transfers { get; set; }

        /// <summary>
        /// The status of the banking capability, or whether the account can have bank accounts.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("treasury")]
        [STJS.JsonPropertyName("treasury")]
        public string Treasury { get; set; }

        /// <summary>
        /// The status of the treasury_evolve capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("treasury_evolve")]
        [STJS.JsonPropertyName("treasury_evolve")]
        public string TreasuryEvolve { get; set; }

        /// <summary>
        /// The status of the treasury_fifth_third capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("treasury_fifth_third")]
        [STJS.JsonPropertyName("treasury_fifth_third")]
        public string TreasuryFifthThird { get; set; }

        /// <summary>
        /// The status of the treasury_goldman_sachs capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("treasury_goldman_sachs")]
        [STJS.JsonPropertyName("treasury_goldman_sachs")]
        public string TreasuryGoldmanSachs { get; set; }

        /// <summary>
        /// The status of the TWINT capability of the account, or whether the account can directly
        /// process TWINT charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("twint_payments")]
        [STJS.JsonPropertyName("twint_payments")]
        public string TwintPayments { get; set; }

        /// <summary>
        /// The status of the US bank account ACH payments capability of the account, or whether the
        /// account can directly process US bank account charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("us_bank_account_ach_payments")]
        [STJS.JsonPropertyName("us_bank_account_ach_payments")]
        public string UsBankAccountAchPayments { get; set; }

        /// <summary>
        /// The status of the US customer_balance payments (USD currency) capability of the account,
        /// or whether the account can directly process US customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
        [STJS.JsonPropertyName("us_bank_transfer_payments")]
        public string UsBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Zip capability of the account, or whether the account can directly
        /// process Zip charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("zip_payments")]
        [STJS.JsonPropertyName("zip_payments")]
        public string ZipPayments { get; set; }
    }
}
