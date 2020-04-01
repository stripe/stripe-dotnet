namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeFraudDetails : StripeEntity<ChargeFraudDetails>
    {
        /// <summary>
        /// Assessments from Stripe. If set, the value is <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("stripe_report")]
        public string StripeReport { get; set; }

        /// <summary>
        /// Assessments reported by you. If set, possible values of are <c>safe</c> and
        /// <c>fraudulent</c>.
        /// </summary>
        [JsonProperty("user_report")]
        public string UserReport { get; set; }
    }
}
