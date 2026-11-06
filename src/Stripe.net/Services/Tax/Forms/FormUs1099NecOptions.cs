// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUs1099NecOptions : INestedOptions
    {
        /// <summary>
        /// Replacement cash tips, where supported by the reporting year.
        /// </summary>
        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099NecCashTipsOptions CashTips { get; set; }

        /// <summary>
        /// Replacement direct-sales indicator.
        /// </summary>
        [JsonProperty("direct_sales_indicator")]
        [STJS.JsonPropertyName("direct_sales_indicator")]
        public bool? DirectSalesIndicator { get; set; }

        /// <summary>
        /// Replacement federal income tax withheld.
        /// </summary>
        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099NecFederalIncomeTaxWithheldOptions FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Replacement nonemployee compensation.
        /// </summary>
        [JsonProperty("nonemployee_compensation")]
        [STJS.JsonPropertyName("nonemployee_compensation")]
        public FormUs1099NecNonemployeeCompensationOptions NonemployeeCompensation { get; set; }

        /// <summary>
        /// Replacement overtime compensation, where supported by the reporting year.
        /// </summary>
        [JsonProperty("overtime_compensation")]
        [STJS.JsonPropertyName("overtime_compensation")]
        public FormUs1099NecOvertimeCompensationOptions OvertimeCompensation { get; set; }

        /// <summary>
        /// Replacement state income.
        /// </summary>
        [JsonProperty("state_income")]
        [STJS.JsonPropertyName("state_income")]
        public FormUs1099NecStateIncomeOptions StateIncome { get; set; }

        /// <summary>
        /// Replacement state tax withheld.
        /// </summary>
        [JsonProperty("state_tax_withheld")]
        [STJS.JsonPropertyName("state_tax_withheld")]
        public FormUs1099NecStateTaxWithheldOptions StateTaxWithheld { get; set; }
    }
}
