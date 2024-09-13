namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the Canadian pre-authorized debits payments capability of the account, or
        /// whether the account can directly process Canadian pre-authorized debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("acss_debit_payments")]
#else
        [JsonProperty("acss_debit_payments")]
#endif
        public string AcssDebitPayments { get; set; }

        /// <summary>
        /// The status of the Affirm capability of the account, or whether the account can directly
        /// process Affirm charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("affirm_payments")]
#else
        [JsonProperty("affirm_payments")]
#endif
        public string AffirmPayments { get; set; }

        /// <summary>
        /// The status of the Afterpay Clearpay capability of the account, or whether the account
        /// can directly process Afterpay Clearpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("afterpay_clearpay_payments")]
#else
        [JsonProperty("afterpay_clearpay_payments")]
#endif
        public string AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The status of the AmazonPay capability of the account, or whether the account can
        /// directly process AmazonPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("amazon_pay_payments")]
#else
        [JsonProperty("amazon_pay_payments")]
#endif
        public string AmazonPayPayments { get; set; }

        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("au_becs_debit_payments")]
#else
        [JsonProperty("au_becs_debit_payments")]
#endif
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bacs Direct Debits payments capability of the account, or whether the
        /// account can directly process Bacs Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("bacs_debit_payments")]
#else
        [JsonProperty("bacs_debit_payments")]
#endif
        public string BacsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bancontact payments capability of the account, or whether the account
        /// can directly process Bancontact charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("bancontact_payments")]
#else
        [JsonProperty("bancontact_payments")]
#endif
        public string BancontactPayments { get; set; }

        /// <summary>
        /// The status of the customer_balance payments capability of the account, or whether the
        /// account can directly process customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("bank_transfer_payments")]
#else
        [JsonProperty("bank_transfer_payments")]
#endif
        public string BankTransferPayments { get; set; }

        /// <summary>
        /// The status of the blik payments capability of the account, or whether the account can
        /// directly process blik charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("blik_payments")]
#else
        [JsonProperty("blik_payments")]
#endif
        public string BlikPayments { get; set; }

        /// <summary>
        /// The status of the boleto payments capability of the account, or whether the account can
        /// directly process boleto charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("boleto_payments")]
#else
        [JsonProperty("boleto_payments")]
#endif
        public string BoletoPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("card_issuing")]
#else
        [JsonProperty("card_issuing")]
#endif
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("card_payments")]
#else
        [JsonProperty("card_payments")]
#endif
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the Cartes Bancaires payments capability of the account, or whether the
        /// account can directly process Cartes Bancaires card charges in EUR currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("cartes_bancaires_payments")]
#else
        [JsonProperty("cartes_bancaires_payments")]
#endif
        public string CartesBancairesPayments { get; set; }

        /// <summary>
        /// The status of the Cash App Pay capability of the account, or whether the account can
        /// directly process Cash App Pay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("cashapp_payments")]
#else
        [JsonProperty("cashapp_payments")]
#endif
        public string CashappPayments { get; set; }

        /// <summary>
        /// The status of the EPS payments capability of the account, or whether the account can
        /// directly process EPS charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("eps_payments")]
#else
        [JsonProperty("eps_payments")]
#endif
        public string EpsPayments { get; set; }

        /// <summary>
        /// The status of the FPX payments capability of the account, or whether the account can
        /// directly process FPX charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("fpx_payments")]
#else
        [JsonProperty("fpx_payments")]
#endif
        public string FpxPayments { get; set; }

        /// <summary>
        /// The status of the GB customer_balance payments (GBP currency) capability of the account,
        /// or whether the account can directly process GB customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("gb_bank_transfer_payments")]
#else
        [JsonProperty("gb_bank_transfer_payments")]
#endif
        public string GbBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the giropay payments capability of the account, or whether the account can
        /// directly process giropay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("giropay_payments")]
#else
        [JsonProperty("giropay_payments")]
#endif
        public string GiropayPayments { get; set; }

        /// <summary>
        /// The status of the GrabPay payments capability of the account, or whether the account can
        /// directly process GrabPay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("grabpay_payments")]
#else
        [JsonProperty("grabpay_payments")]
#endif
        public string GrabpayPayments { get; set; }

        /// <summary>
        /// The status of the iDEAL payments capability of the account, or whether the account can
        /// directly process iDEAL charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("ideal_payments")]
#else
        [JsonProperty("ideal_payments")]
#endif
        public string IdealPayments { get; set; }

        /// <summary>
        /// The status of the india_international_payments capability of the account, or whether the
        /// account can process international charges (non INR) in India.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("india_international_payments")]
#else
        [JsonProperty("india_international_payments")]
#endif
        public string IndiaInternationalPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("jcb_payments")]
#else
        [JsonProperty("jcb_payments")]
#endif
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the Japanese customer_balance payments (JPY currency) capability of the
        /// account, or whether the account can directly process Japanese customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("jp_bank_transfer_payments")]
#else
        [JsonProperty("jp_bank_transfer_payments")]
#endif
        public string JpBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Klarna payments capability of the account, or whether the account can
        /// directly process Klarna charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("klarna_payments")]
#else
        [JsonProperty("klarna_payments")]
#endif
        public string KlarnaPayments { get; set; }

        /// <summary>
        /// The status of the konbini payments capability of the account, or whether the account can
        /// directly process konbini charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("konbini_payments")]
#else
        [JsonProperty("konbini_payments")]
#endif
        public string KonbiniPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("legacy_payments")]
#else
        [JsonProperty("legacy_payments")]
#endif
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the link_payments capability of the account, or whether the account can
        /// directly process Link charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("link_payments")]
#else
        [JsonProperty("link_payments")]
#endif
        public string LinkPayments { get; set; }

        /// <summary>
        /// The status of the MobilePay capability of the account, or whether the account can
        /// directly process MobilePay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("mobilepay_payments")]
#else
        [JsonProperty("mobilepay_payments")]
#endif
        public string MobilepayPayments { get; set; }

        /// <summary>
        /// The status of the Multibanco payments capability of the account, or whether the account
        /// can directly process Multibanco charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("multibanco_payments")]
#else
        [JsonProperty("multibanco_payments")]
#endif
        public string MultibancoPayments { get; set; }

        /// <summary>
        /// The status of the Mexican customer_balance payments (MXN currency) capability of the
        /// account, or whether the account can directly process Mexican customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("mx_bank_transfer_payments")]
#else
        [JsonProperty("mx_bank_transfer_payments")]
#endif
        public string MxBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the OXXO payments capability of the account, or whether the account can
        /// directly process OXXO charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("oxxo_payments")]
#else
        [JsonProperty("oxxo_payments")]
#endif
        public string OxxoPayments { get; set; }

        /// <summary>
        /// The status of the P24 payments capability of the account, or whether the account can
        /// directly process P24 charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("p24_payments")]
#else
        [JsonProperty("p24_payments")]
#endif
        public string P24Payments { get; set; }

        /// <summary>
        /// The status of the paynow payments capability of the account, or whether the account can
        /// directly process paynow charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("paynow_payments")]
#else
        [JsonProperty("paynow_payments")]
#endif
        public string PaynowPayments { get; set; }

        /// <summary>
        /// The status of the promptpay payments capability of the account, or whether the account
        /// can directly process promptpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("promptpay_payments")]
#else
        [JsonProperty("promptpay_payments")]
#endif
        public string PromptpayPayments { get; set; }

        /// <summary>
        /// The status of the RevolutPay capability of the account, or whether the account can
        /// directly process RevolutPay payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("revolut_pay_payments")]
#else
        [JsonProperty("revolut_pay_payments")]
#endif
        public string RevolutPayPayments { get; set; }

        /// <summary>
        /// The status of the SEPA customer_balance payments (EUR currency) capability of the
        /// account, or whether the account can directly process SEPA customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("sepa_bank_transfer_payments")]
#else
        [JsonProperty("sepa_bank_transfer_payments")]
#endif
        public string SepaBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the SEPA Direct Debits payments capability of the account, or whether the
        /// account can directly process SEPA Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("sepa_debit_payments")]
#else
        [JsonProperty("sepa_debit_payments")]
#endif
        public string SepaDebitPayments { get; set; }

        /// <summary>
        /// The status of the Sofort payments capability of the account, or whether the account can
        /// directly process Sofort charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("sofort_payments")]
#else
        [JsonProperty("sofort_payments")]
#endif
        public string SofortPayments { get; set; }

        /// <summary>
        /// The status of the Swish capability of the account, or whether the account can directly
        /// process Swish payments.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("swish_payments")]
#else
        [JsonProperty("swish_payments")]
#endif
        public string SwishPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_reporting_us_1099_k")]
#else
        [JsonProperty("tax_reporting_us_1099_k")]
#endif
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("tax_reporting_us_1099_misc")]
#else
        [JsonProperty("tax_reporting_us_1099_misc")]
#endif
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("transfers")]
#else
        [JsonProperty("transfers")]
#endif
        public string Transfers { get; set; }

        /// <summary>
        /// The status of the banking capability, or whether the account can have bank accounts.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("treasury")]
#else
        [JsonProperty("treasury")]
#endif
        public string Treasury { get; set; }

        /// <summary>
        /// The status of the TWINT capability of the account, or whether the account can directly
        /// process TWINT charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("twint_payments")]
#else
        [JsonProperty("twint_payments")]
#endif
        public string TwintPayments { get; set; }

        /// <summary>
        /// The status of the US bank account ACH payments capability of the account, or whether the
        /// account can directly process US bank account charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("us_bank_account_ach_payments")]
#else
        [JsonProperty("us_bank_account_ach_payments")]
#endif
        public string UsBankAccountAchPayments { get; set; }

        /// <summary>
        /// The status of the US customer_balance payments (USD currency) capability of the account,
        /// or whether the account can directly process US customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("us_bank_transfer_payments")]
#else
        [JsonProperty("us_bank_transfer_payments")]
#endif
        public string UsBankTransferPayments { get; set; }

        /// <summary>
        /// The status of the Zip capability of the account, or whether the account can directly
        /// process Zip charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("zip_payments")]
#else
        [JsonProperty("zip_payments")]
#endif
        public string ZipPayments { get; set; }
    }
}
