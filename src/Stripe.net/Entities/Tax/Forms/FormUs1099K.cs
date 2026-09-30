// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormUs1099K : StripeEntity<FormUs1099K>
    {
        [JsonProperty("card_not_present_transactions")]
        [STJS.JsonPropertyName("card_not_present_transactions")]
        public FormUs1099KCardNotPresentTransactions CardNotPresentTransactions { get; set; }

        [JsonProperty("cash_tips")]
        [STJS.JsonPropertyName("cash_tips")]
        public FormUs1099KCashTips CashTips { get; set; }

        /// <summary>
        /// The currency of the amounts on the form. Always <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("federal_income_tax_withheld")]
        [STJS.JsonPropertyName("federal_income_tax_withheld")]
        public FormUs1099KFederalIncomeTaxWithheld FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// The gross amount of payment transactions, as a decimal string in USD.
        /// </summary>
        [JsonProperty("gross_amount_of_transactions_decimal")]
        [STJS.JsonPropertyName("gross_amount_of_transactions_decimal")]
        public string GrossAmountOfTransactionsDecimal { get; set; }

        /// <summary>
        /// The gross amounts for each month, ordered from January through December.
        /// </summary>
        [JsonProperty("monthly_volumes")]
        [STJS.JsonPropertyName("monthly_volumes")]
        public List<FormUs1099KMonthlyVolume> MonthlyVolumes { get; set; }

        [JsonProperty("payment_transactions_count")]
        [STJS.JsonPropertyName("payment_transactions_count")]
        public FormUs1099KPaymentTransactionsCount PaymentTransactionsCount { get; set; }

        /// <summary>
        /// Year represented by the information reported on the tax form.
        /// </summary>
        [JsonProperty("reporting_year")]
        [STJS.JsonPropertyName("reporting_year")]
        public long ReportingYear { get; set; }

        [JsonProperty("state_income_tax_withheld")]
        [STJS.JsonPropertyName("state_income_tax_withheld")]
        public FormUs1099KStateIncomeTaxWithheld StateIncomeTaxWithheld { get; set; }
    }
}
