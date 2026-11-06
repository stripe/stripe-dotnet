// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormUs1099KOptions : INestedOptions
    {
        /// <summary>
        /// Replacement card-not-present transaction amount.
        /// </summary>
        [JsonProperty("card_not_present_transactions")]
        [STJS.JsonPropertyName("card_not_present_transactions")]
        public FormUs1099KCardNotPresentTransactionsOptions CardNotPresentTransactions { get; set; }

        /// <summary>
        /// Replacement cash tips, where supported by the reporting year.
        /// </summary>
        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099KCashTipsOptions CashTips { get; set; }

        /// <summary>
        /// Replacement federal income tax withheld.
        /// </summary>
        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099KFederalIncomeTaxWithheldOptions FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Replacement amounts for all twelve months, from January through December.
        /// </summary>
        [JsonProperty("monthly_volumes")]
        [STJS.JsonPropertyName("monthly_volumes")]
        public List<FormUs1099KMonthlyVolumeOptions> MonthlyVolumes { get; set; }

        /// <summary>
        /// Replacement payment transaction count.
        /// </summary>
        [JsonProperty("payment_transactions_count")]
        [STJS.JsonPropertyName("payment_transactions_count")]
        public FormUs1099KPaymentTransactionsCountOptions PaymentTransactionsCount { get; set; }

        /// <summary>
        /// Replacement state income tax withheld.
        /// </summary>
        [JsonProperty("state_income_tax_withheld")]
        [STJS.JsonPropertyName("state_income_tax_withheld")]
        public FormUs1099KStateIncomeTaxWithheldOptions StateIncomeTaxWithheld { get; set; }
    }
}
