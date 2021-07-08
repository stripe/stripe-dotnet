// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionData : StripeEntity<QuoteSubscriptionData>
    {
        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. This date is ignored if it is in the past when the quote is
        /// accepted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
