// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099Nec : StripeEntity<FormUs1099Nec>
    {
        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099NecCashTips CashTips { get; set; }

        /// <summary>
        /// The currency of the amounts on the form. Always <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether direct sales of at least $5,000 of consumer products were made for resale.
        /// </summary>
        [JsonProperty("direct_sales_indicator")]
        [STJS.JsonPropertyName("direct_sales_indicator")]
        public bool DirectSalesIndicator { get; set; }

        /// <summary>
        /// Whether the FATCA filing requirement applies.
        /// </summary>
        [JsonProperty("fatca_filing_requirement")]
        [STJS.JsonPropertyName("fatca_filing_requirement")]
        public bool FatcaFilingRequirement { get; set; }

        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099NecFederalIncomeTaxWithheld FederalIncomeTaxWithheld { get; set; }

        [JsonProperty("nonemployee_compensation")]
        [STJS.JsonPropertyName("nonemployee_compensation")]
        public FormUs1099NecNonemployeeCompensation NonemployeeCompensation { get; set; }

        [JsonProperty("overtime_compensation")]
        [STJS.JsonPropertyName("overtime_compensation")]
        public FormUs1099NecOvertimeCompensation OvertimeCompensation { get; set; }

        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
        [STJS.JsonPropertyName("reporting_year")]
        public long ReportingYear { get; set; }

        [JsonProperty("state_income")]
        [STJS.JsonPropertyName("state_income")]
        public FormUs1099NecStateIncome StateIncome { get; set; }

        [JsonProperty("state_tax_withheld")]
        [STJS.JsonPropertyName("state_tax_withheld")]
        public FormUs1099NecStateTaxWithheld StateTaxWithheld { get; set; }

        /// <summary>
        /// The Treasury Tipped Occupation Code stored on the form's payee identity, returned when
        /// present regardless of reporting year. Contains one three-digit code or two codes
        /// separated by <c>|</c>, preserving leading zeros. Uses the selected identity for draft
        /// forms and the identity snapshot for finalized forms. Omitted when no code is recorded.
        /// </summary>
        [JsonProperty("treasury_tipped_occupation_code")]
        [STJS.JsonPropertyName("treasury_tipped_occupation_code")]
        public string TreasuryTippedOccupationCode { get; set; }
    }
}
