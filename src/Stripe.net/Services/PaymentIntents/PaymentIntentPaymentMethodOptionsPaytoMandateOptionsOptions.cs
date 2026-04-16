// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsPaytoMandateOptionsOptions : INestedOptions, IHasSetTracking
    {
        private long? amount;
        private string amountType;
        private string endDate;
        private string paymentSchedule;
        private long? paymentsPerPeriod;
        private string purpose;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Amount that will be collected. It is required when <c>amount_type</c> is <c>fixed</c>.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? Amount
        {
            get => this.amount;
            set
            {
                this.amount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The type of amount that will be collected. The amount charged must be exact or up to the
        /// value of <c>amount</c> param for <c>fixed</c> or <c>maximum</c> type respectively.
        /// Defaults to <c>maximum</c>.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        /// </summary>
        [JsonProperty("amount_type", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount_type")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string AmountType
        {
            get => this.amountType;
            set
            {
                this.amountType = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Date, in YYYY-MM-DD format, after which payments will not be collected. Defaults to no
        /// end date.
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("end_date")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string EndDate
        {
            get => this.endDate;
            set
            {
                this.endDate = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The periodicity at which payments will be collected. Defaults to <c>adhoc</c>.
        /// One of: <c>adhoc</c>, <c>annual</c>, <c>daily</c>, <c>fortnightly</c>, <c>monthly</c>,
        /// <c>quarterly</c>, <c>semi_annual</c>, or <c>weekly</c>.
        /// </summary>
        [JsonProperty("payment_schedule", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payment_schedule")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string PaymentSchedule
        {
            get => this.paymentSchedule;
            set
            {
                this.paymentSchedule = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The number of payments that will be made during a payment period. Defaults to 1 except
        /// for when <c>payment_schedule</c> is <c>adhoc</c>. In that case, it defaults to no limit.
        /// </summary>
        [JsonProperty("payments_per_period", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("payments_per_period")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? PaymentsPerPeriod
        {
            get => this.paymentsPerPeriod;
            set
            {
                this.paymentsPerPeriod = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The purpose for which payments are made. Has a default value based on your merchant
        /// category code.
        /// One of: <c>dependant_support</c>, <c>government</c>, <c>loan</c>, <c>mortgage</c>,
        /// <c>other</c>, <c>pension</c>, <c>personal</c>, <c>retail</c>, <c>salary</c>, <c>tax</c>,
        /// or <c>utility</c>.
        /// </summary>
        [JsonProperty("purpose", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("purpose")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Purpose
        {
            get => this.purpose;
            set
            {
                this.purpose = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
