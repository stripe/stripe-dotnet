// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteSubscriptionDataOptions : INestedOptions, IHasMetadata, IHasSetTracking
    {
        private string description;
        private AnyOf<DateTime?, QuoteSubscriptionDataEffectiveDate> effectiveDate;
        private long? trialPeriodDays;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
        [STJS.JsonPropertyName("billing_mode")]
        public QuoteSubscriptionDataBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Description
        {
            get => this.description;
            set
            {
                this.description = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// When creating a new subscription, the date of which the subscription schedule will start
        /// after the quote is accepted. The <c>effective_date</c> is ignored if it is in the past
        /// when the quote is accepted.
        /// </summary>
        [JsonProperty("effective_date", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("effective_date")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, QuoteSubscriptionDataEffectiveDate> EffectiveDate
        {
            get => this.effectiveDate;
            set
            {
                this.effectiveDate = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that will set
        /// metadata on the subscription or subscription schedule when the quote is accepted. If a
        /// recurring price is included in <c>line_items</c>, this field will be passed to the
        /// resulting subscription's <c>metadata</c> field. If
        /// <c>subscription_data.effective_date</c> is used, this field will be passed to the
        /// resulting subscription schedule's <c>phases.metadata</c> field. Unlike object-level
        /// metadata, this field is declarative. Updates will clear prior values.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("trial_period_days")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? TrialPeriodDays
        {
            get => this.trialPeriodDays;
            set
            {
                this.trialPeriodDays = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
