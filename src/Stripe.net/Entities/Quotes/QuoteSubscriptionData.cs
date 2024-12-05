// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteSubscriptionData : StripeEntity<QuoteSubscriptionData>, IHasMetadata
    {
        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. This date is ignored if it is in the past when the quote is
        /// accepted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("effective_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will set
        /// metadata on the subscription or subscription schedule when the quote is accepted. If a
        /// recurring price is included in <c>line_items</c>, this field will be passed to the
        /// resulting subscription's <c>metadata</c> field. If
        /// <c>subscription_data.effective_date</c> is used, this field will be passed to the
        /// resulting subscription schedule's <c>phases.metadata</c> field. Unlike object-level
        /// metadata, this field is declarative. Updates will clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
