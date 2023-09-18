// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Filter subscriptions by their automatic tax settings.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public SubscriptionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The collection method of the subscriptions to retrieve. Either
        /// <c>charge_automatically</c> or <c>send_invoice</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodStart { get; set; }

        /// <summary>
        /// The ID of the customer whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the plan whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Filter for subscriptions that contain this recurring price ID.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// The status of the subscriptions to retrieve. Passing in a value of <c>canceled</c> will
        /// return all canceled subscriptions, including those belonging to deleted customers. Pass
        /// <c>ended</c> to find subscriptions that are canceled and subscriptions that are expired
        /// due to <a
        /// href="https://stripe.com/docs/billing/subscriptions/overview#subscription-statuses">incomplete
        /// payment</a>. Passing in a value of <c>all</c> will return subscriptions of all statuses.
        /// If no value is supplied, all subscriptions that have not been canceled are returned.
        /// One of: <c>active</c>, <c>all</c>, <c>canceled</c>, <c>ended</c>, <c>incomplete</c>,
        /// <c>incomplete_expired</c>, <c>past_due</c>, <c>paused</c>, <c>trialing</c>, or
        /// <c>unpaid</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Filter for subscriptions that are associated with the specified test clock. The response
        /// will not include subscriptions with test clocks if this and the customer parameter is
        /// not set.
        /// </summary>
        [JsonProperty("test_clock")]
        public string TestClock { get; set; }
    }
}
