namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// The au_becs_debit_payments capability.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        public AccountCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The bacs_debit_payments capability.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        public AccountCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// The card_issuing capability.
        /// </summary>
        [JsonProperty("card_issuing")]
        public AccountCapabilitiesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// The card_payments capability.
        /// </summary>
        [JsonProperty("card_payments")]
        public AccountCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// The cartes_bancaires_payments capability.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        public AccountCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// The fpx_payments capability.
        /// </summary>
        [JsonProperty("fpx_payments")]
        public AccountCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// The jcb_payments capability.
        /// </summary>
        [JsonProperty("jcb_payments")]
        public AccountCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// The legacy_payments capability.
        /// </summary>
        [JsonProperty("legacy_payments")]
        public AccountCapabilitiesLegacyPaymentsOptions LegacyPayments { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_k capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
        public AccountCapabilitiesTaxReportingUs1099KOptions TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_misc capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
        public AccountCapabilitiesTaxReportingUs1099MiscOptions TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The transfers capability.
        /// </summary>
        [JsonProperty("transfers")]
        public AccountCapabilitiesTransfersOptions Transfers { get; set; }
    }
}
