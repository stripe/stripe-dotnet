// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099Misc : StripeEntity<FormUs1099Misc>
    {
        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099MiscCashTips CashTips { get; set; }

        [JsonProperty("crop_insurance_proceeds")]
        [STJS.JsonPropertyName("crop_insurance_proceeds")]
        public FormUs1099MiscCropInsuranceProceeds CropInsuranceProceeds { get; set; }

        /// <summary>
        /// The currency of the amounts on the form. Always <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Whether direct sales of at least $5,000 of consumer products were made for resale.
        /// </summary>
        [JsonProperty("direct_sales_for_resale")]
        [STJS.JsonPropertyName("direct_sales_for_resale")]
        public bool DirectSalesForResale { get; set; }

        [JsonProperty("excess_golden_parachute_payments")]
        [STJS.JsonPropertyName("excess_golden_parachute_payments")]
        public FormUs1099MiscExcessGoldenParachutePayments ExcessGoldenParachutePayments { get; set; }

        /// <summary>
        /// Whether the FATCA filing requirement applies.
        /// </summary>
        [JsonProperty("fatca_filing_required")]
        [STJS.JsonPropertyName("fatca_filing_required")]
        public bool FatcaFilingRequired { get; set; }

        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099MiscFederalIncomeTaxWithheld FederalIncomeTaxWithheld { get; set; }

        [JsonProperty("fish_purchased_for_resale")]
        [STJS.JsonPropertyName("fish_purchased_for_resale")]
        public FormUs1099MiscFishPurchasedForResale FishPurchasedForResale { get; set; }

        [JsonProperty("fishing_boat_proceeds")]
        [STJS.JsonPropertyName("fishing_boat_proceeds")]
        public FormUs1099MiscFishingBoatProceeds FishingBoatProceeds { get; set; }

        [JsonProperty("gross_proceeds_paid_to_an_attorney")]
        [STJS.JsonPropertyName("gross_proceeds_paid_to_an_attorney")]
        public FormUs1099MiscGrossProceedsPaidToAnAttorney GrossProceedsPaidToAnAttorney { get; set; }

        [JsonProperty("medical_and_health_care_payments")]
        [STJS.JsonPropertyName("medical_and_health_care_payments")]
        public FormUs1099MiscMedicalAndHealthCarePayments MedicalAndHealthCarePayments { get; set; }

        [JsonProperty("nonqualified_deferred_compensation")]
        [STJS.JsonPropertyName("nonqualified_deferred_compensation")]
        public FormUs1099MiscNonqualifiedDeferredCompensation NonqualifiedDeferredCompensation { get; set; }

        [JsonProperty("other_income")]
        [STJS.JsonPropertyName("other_income")]
        public FormUs1099MiscOtherIncome OtherIncome { get; set; }

        [JsonProperty("overtime_compensation")]
        [STJS.JsonPropertyName("overtime_compensation")]
        public FormUs1099MiscOvertimeCompensation OvertimeCompensation { get; set; }

        [JsonProperty("rents")]
        [STJS.JsonPropertyName("rents")]
        public FormUs1099MiscRents Rents { get; set; }

        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
        [STJS.JsonPropertyName("reporting_year")]
        public long ReportingYear { get; set; }

        [JsonProperty("royalties")]
        [STJS.JsonPropertyName("royalties")]
        public FormUs1099MiscRoyalties Royalties { get; set; }

        [JsonProperty("section_409a_deferrals")]
        [STJS.JsonPropertyName("section_409a_deferrals")]
        public FormUs1099MiscSection409aDeferrals Section409aDeferrals { get; set; }

        [JsonProperty("state_income")]
        [STJS.JsonPropertyName("state_income")]
        public FormUs1099MiscStateIncome StateIncome { get; set; }

        [JsonProperty("state_tax_withheld")]
        [STJS.JsonPropertyName("state_tax_withheld")]
        public FormUs1099MiscStateTaxWithheld StateTaxWithheld { get; set; }

        [JsonProperty("substitute_payments")]
        [STJS.JsonPropertyName("substitute_payments")]
        public FormUs1099MiscSubstitutePayments SubstitutePayments { get; set; }
    }
}
