namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesOptions : INestedOptions
    {
        [JsonProperty("au_becs_debit_payments")]
        public AccountCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        [JsonProperty("bacs_debit_payments")]
        public AccountCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        [JsonProperty("card_issuing")]
        public AccountCapabilitiesCardIssuingOptions CardIssuing { get; set; }

        [JsonProperty("card_payments")]
        public AccountCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        [JsonProperty("cartes_bancaires_payments")]
        public AccountCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        [JsonProperty("fpx_payments")]
        public AccountCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        [JsonProperty("jcb_payments")]
        public AccountCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        [JsonProperty("legacy_payments")]
        public AccountCapabilitiesLegacyPaymentsOptions LegacyPayments { get; set; }

        [JsonProperty("tax_reporting_us_1099_k")]
        public AccountCapabilitiesTaxReportingUs1099KOptions TaxReportingUs1099K { get; set; }

        [JsonProperty("tax_reporting_us_1099_misc")]
        public AccountCapabilitiesTaxReportingUs1099MiscOptions TaxReportingUs1099Misc { get; set; }

        [JsonProperty("transfers")]
        public AccountCapabilitiesTransfersOptions Transfers { get; set; }
    }
}
