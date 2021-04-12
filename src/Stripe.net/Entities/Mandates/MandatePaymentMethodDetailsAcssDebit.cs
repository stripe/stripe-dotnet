// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsAcssDebit : StripeEntity<MandatePaymentMethodDetailsAcssDebit>
    {
        /// <summary>
        /// Description of the interval. Only required if 'payment_schedule' parmeter is 'interval'
        /// or 'combined'.
        /// </summary>
        [JsonProperty("interval_description")]
        public string IntervalDescription { get; set; }

        /// <summary>
        /// Payment schedule for the mandate.
        /// One of: <c>combined</c>, <c>interval</c>, or <c>sporadic</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }
    }
}
