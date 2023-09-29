// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleAmendmentAmendmentStartOptions : INestedOptions
    {
        /// <summary>
        /// Details of another amendment in the same array, immediately after which this amendment
        /// should begin.
        /// </summary>
        [JsonProperty("amendment_end")]
        public SubscriptionScheduleAmendmentAmendmentStartAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
        public SubscriptionScheduleAmendmentAmendmentStartDiscountEndOptions DiscountEnd { get; set; }

        /// <summary>
        /// A precise Unix timestamp for the amendment to start.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of three ways to pass the <c>amendment_start</c>.
        /// One of: <c>amendment_end</c>, <c>discount_end</c>, <c>now</c>, <c>schedule_end</c>,
        /// <c>timestamp</c>, <c>trial_end</c>, <c>trial_start</c>, or <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
