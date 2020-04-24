namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// </summary>
        [JsonProperty("card_issuing")]
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// </summary>
        [JsonProperty("card_payments")]
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// </summary>
        [JsonProperty("jcb_payments")]
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// </summary>
        [JsonProperty("legacy_payments")]
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// </summary>
        [JsonProperty("transfers")]
        public string Transfers { get; set; }
    }
}
