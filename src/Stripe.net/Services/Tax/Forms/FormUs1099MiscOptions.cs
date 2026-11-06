// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUs1099MiscOptions : INestedOptions
    {
        /// <summary>
        /// Replacement cash tips, where supported by the reporting year.
        /// </summary>
        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099MiscCashTipsOptions CashTips { get; set; }

        /// <summary>
        /// Replacement crop insurance proceeds.
        /// </summary>
        [JsonProperty("crop_insurance_proceeds")]
        [STJS.JsonPropertyName("crop_insurance_proceeds")]
        public FormUs1099MiscCropInsuranceProceedsOptions CropInsuranceProceeds { get; set; }

        /// <summary>
        /// Replacement direct-sales-for-resale indicator.
        /// </summary>
        [JsonProperty("direct_sales_for_resale")]
        [STJS.JsonPropertyName("direct_sales_for_resale")]
        public bool? DirectSalesForResale { get; set; }

        /// <summary>
        /// Replacement excess golden parachute payments, where supported by the reporting year.
        /// </summary>
        [JsonProperty("excess_golden_parachute_payments")]
        [STJS.JsonPropertyName("excess_golden_parachute_payments")]
        public FormUs1099MiscExcessGoldenParachutePaymentsOptions ExcessGoldenParachutePayments { get; set; }

        /// <summary>
        /// Replacement FATCA filing requirement; cannot be supplied without a substantive
        /// correction.
        /// </summary>
        [JsonProperty("fatca_filing_required")]
        [STJS.JsonPropertyName("fatca_filing_required")]
        public bool? FatcaFilingRequired { get; set; }

        /// <summary>
        /// Replacement federal income tax withheld.
        /// </summary>
        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099MiscFederalIncomeTaxWithheldOptions FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Replacement fish purchased for resale.
        /// </summary>
        [JsonProperty("fish_purchased_for_resale")]
        [STJS.JsonPropertyName("fish_purchased_for_resale")]
        public FormUs1099MiscFishPurchasedForResaleOptions FishPurchasedForResale { get; set; }

        /// <summary>
        /// Replacement fishing boat proceeds.
        /// </summary>
        [JsonProperty("fishing_boat_proceeds")]
        [STJS.JsonPropertyName("fishing_boat_proceeds")]
        public FormUs1099MiscFishingBoatProceedsOptions FishingBoatProceeds { get; set; }

        /// <summary>
        /// Replacement gross proceeds paid to an attorney.
        /// </summary>
        [JsonProperty("gross_proceeds_paid_to_an_attorney")]
        [STJS.JsonPropertyName("gross_proceeds_paid_to_an_attorney")]
        public FormUs1099MiscGrossProceedsPaidToAnAttorneyOptions GrossProceedsPaidToAnAttorney { get; set; }

        /// <summary>
        /// Replacement medical and health care payments.
        /// </summary>
        [JsonProperty("medical_and_health_care_payments")]
        [STJS.JsonPropertyName("medical_and_health_care_payments")]
        public FormUs1099MiscMedicalAndHealthCarePaymentsOptions MedicalAndHealthCarePayments { get; set; }

        /// <summary>
        /// Replacement nonqualified deferred compensation.
        /// </summary>
        [JsonProperty("nonqualified_deferred_compensation")]
        [STJS.JsonPropertyName("nonqualified_deferred_compensation")]
        public FormUs1099MiscNonqualifiedDeferredCompensationOptions NonqualifiedDeferredCompensation { get; set; }

        /// <summary>
        /// Replacement other income.
        /// </summary>
        [JsonProperty("other_income")]
        [STJS.JsonPropertyName("other_income")]
        public FormUs1099MiscOtherIncomeOptions OtherIncome { get; set; }

        /// <summary>
        /// Replacement overtime compensation, where supported by the reporting year.
        /// </summary>
        [JsonProperty("overtime_compensation")]
        [STJS.JsonPropertyName("overtime_compensation")]
        public FormUs1099MiscOvertimeCompensationOptions OvertimeCompensation { get; set; }

        /// <summary>
        /// Replacement rents.
        /// </summary>
        [JsonProperty("rents")]
        [STJS.JsonPropertyName("rents")]
        public FormUs1099MiscRentsOptions Rents { get; set; }

        /// <summary>
        /// Replacement royalties.
        /// </summary>
        [JsonProperty("royalties")]
        [STJS.JsonPropertyName("royalties")]
        public FormUs1099MiscRoyaltiesOptions Royalties { get; set; }

        /// <summary>
        /// Replacement section 409A deferrals.
        /// </summary>
        [JsonProperty("section_409a_deferrals")]
        [STJS.JsonPropertyName("section_409a_deferrals")]
        public FormUs1099MiscSection409aDeferralsOptions Section409aDeferrals { get; set; }

        /// <summary>
        /// Replacement state income.
        /// </summary>
        [JsonProperty("state_income")]
        [STJS.JsonPropertyName("state_income")]
        public FormUs1099MiscStateIncomeOptions StateIncome { get; set; }

        /// <summary>
        /// Replacement state tax withheld.
        /// </summary>
        [JsonProperty("state_tax_withheld")]
        [STJS.JsonPropertyName("state_tax_withheld")]
        public FormUs1099MiscStateTaxWithheldOptions StateTaxWithheld { get; set; }

        /// <summary>
        /// Replacement substitute payments.
        /// </summary>
        [JsonProperty("substitute_payments")]
        [STJS.JsonPropertyName("substitute_payments")]
        public FormUs1099MiscSubstitutePaymentsOptions SubstitutePayments { get; set; }
    }
}
