// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. When updating a subscription, the date of which the
        /// subscription will be updated using a subscription schedule. The special value
        /// <c>current_period_end</c> can be provided to update a subscription at the end of its
        /// current period. The <c>effective_date</c> is ignored if it is in the past when the quote
        /// is accepted.
        /// </summary>
        [JsonProperty("effective_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_date")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif

        public AnyOf<DateTime?, QuoteSubscriptionDataEffectiveDate> EffectiveDate { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_period_days")]
#endif

        public long? TrialPeriodDays { get; set; }
    }
}
