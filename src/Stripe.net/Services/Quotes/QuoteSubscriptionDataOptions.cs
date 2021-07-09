// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionDataOptions : INestedOptions
    {
        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. When updating a subscription, the date of which the
        /// subscription will be updated using a subscription schedule. The special value
        /// <c>current_period_end</c> can be provided to update a subscription at the end of its
        /// current period. The <c>effective_date</c> is ignored if it is in the past when the quote
        /// is accepted.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, QuoteSubscriptionDataEffectiveDate> EffectiveDate { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
