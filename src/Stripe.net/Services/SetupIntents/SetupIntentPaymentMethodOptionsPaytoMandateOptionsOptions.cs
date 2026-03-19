// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsPaytoMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Amount that will be collected. It is required when <c>amount_type</c> is <c>fixed</c>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The type of amount that will be collected. The amount charged must be exact or up to the
        /// value of <c>amount</c> param for <c>fixed</c> or <c>maximum</c> type respectively.
        /// Defaults to <c>maximum</c>.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type")]
        [STJS.JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// Date, in YYYY-MM-DD format, after which payments will not be collected. Defaults to no
        /// end date.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// The periodicity at which payments will be collected. Defaults to <c>adhoc</c>.
        /// One of: <c>adhoc</c>, <c>annual</c>, <c>daily</c>, <c>fortnightly</c>, <c>monthly</c>,
        /// <c>quarterly</c>, <c>semi_annual</c>, or <c>weekly</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        [STJS.JsonPropertyName("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// The number of payments that will be made during a payment period. Defaults to 1 except
        /// for when <c>payment_schedule</c> is <c>adhoc</c>. In that case, it defaults to no limit.
        /// </summary>
        [JsonProperty("payments_per_period")]
        [STJS.JsonPropertyName("payments_per_period")]
        public long? PaymentsPerPeriod { get; set; }

        /// <summary>
        /// The purpose for which payments are made. Has a default value based on your merchant
        /// category code.
        /// One of: <c>dependant_support</c>, <c>government</c>, <c>loan</c>, <c>mortgage</c>,
        /// <c>other</c>, <c>pension</c>, <c>personal</c>, <c>retail</c>, <c>salary</c>, <c>tax</c>,
        /// or <c>utility</c>.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Date, in YYYY-MM-DD format, from which payments will be collected. Defaults to
        /// confirmation time.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
