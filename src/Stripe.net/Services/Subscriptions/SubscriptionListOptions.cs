// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionListOptions : ListOptions
    {
        /// <summary>
        /// Filter subscriptions by their automatic tax settings.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public SubscriptionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// The collection method of the subscriptions to retrieve. Either
        /// <c>charge_automatically</c> or <c>send_invoice</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Only return subscriptions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return subscriptions whose minimum item current_period_end falls within the given
        /// date interval.
        /// </summary>
        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_period_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodEnd { get; set; }

        /// <summary>
        /// Only return subscriptions whose maximum item current_period_start falls within the given
        /// date interval.
        /// </summary>
        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_period_start")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodStart { get; set; }

        /// <summary>
        /// The ID of the customer whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the account whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The ID of the plan whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("plan")]
#endif
        public string Plan { get; set; }

        /// <summary>
        /// Filter for subscriptions that contain this recurring price ID.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Filter for subscriptions that are associated with the specified test clock. The response
        /// will not include subscriptions with test clocks if this and the customer parameter is
        /// not set.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }
    }
}
