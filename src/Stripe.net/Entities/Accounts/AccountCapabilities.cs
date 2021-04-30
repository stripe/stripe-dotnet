// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the ACSS Direct Debits payments capability of the account, or whether the
        /// account can directly process ACSS Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
        public string AcssDebitPayments { get; set; }

        /// <summary>
        /// The status of the Afterpay Clearpay capability of the account, or whether the account
        /// can directly process Afterpay Clearpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
        public string AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bacs Direct Debits payments capability of the account, or whether the
        /// account can directly process Bacs Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        public string BacsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bancontact payments capability of the account, or whether the account
        /// can directly process Bancontact charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("bancontact_payments")]
        public string BancontactPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_issuing")]
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("card_payments")]
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the Cartes Bancaires payments capability of the account, or whether the
        /// account can directly process Cartes Bancaires card charges in EUR currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        public string CartesBancairesPayments { get; set; }

        /// <summary>
        /// The status of the EPS payments capability of the account, or whether the account can
        /// directly process EPS charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("eps_payments")]
        public string EpsPayments { get; set; }

        /// <summary>
        /// The status of the FPX payments capability of the account, or whether the account can
        /// directly process FPX charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("fpx_payments")]
        public string FpxPayments { get; set; }

        /// <summary>
        /// The status of the giropay payments capability of the account, or whether the account can
        /// directly process giropay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("giropay_payments")]
        public string GiropayPayments { get; set; }

        /// <summary>
        /// The status of the GrabPay payments capability of the account, or whether the account can
        /// directly process GrabPay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("grabpay_payments")]
        public string GrabpayPayments { get; set; }

        /// <summary>
        /// The status of the iDEAL payments capability of the account, or whether the account can
        /// directly process iDEAL charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("ideal_payments")]
        public string IdealPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("jcb_payments")]
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("legacy_payments")]
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the OXXO payments capability of the account, or whether the account can
        /// directly process OXXO charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("oxxo_payments")]
        public string OxxoPayments { get; set; }

        /// <summary>
        /// The status of the P24 payments capability of the account, or whether the account can
        /// directly process P24 charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("p24_payments")]
        public string P24Payments { get; set; }

        /// <summary>
        /// The status of the SEPA Direct Debits payments capability of the account, or whether the
        /// account can directly process SEPA Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        public string SepaDebitPayments { get; set; }

        /// <summary>
        /// The status of the Sofort payments capability of the account, or whether the account can
        /// directly process Sofort charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("sofort_payments")]
        public string SofortPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("transfers")]
        public string Transfers { get; set; }
    }
}
