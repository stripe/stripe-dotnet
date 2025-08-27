// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Rate Card represents a versioned set of usage-based prices (rates). Each rate is
    /// associated with one Metered Item and defines how much to charge for usage of that item.
    /// After you've set up a RateCard, you can subscribe customers to it by creating a Rate
    /// Card Subscription.
    /// </summary>
    public class RateCard : StripeEntity<RateCard>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Whether this RateCard is active. Inactive RateCards cannot be used in new activations or
        /// have new rates added.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool Active { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// A customer-facing name for the Rate Card. This name is used in Stripe-hosted products
        /// like the Customer Portal and Checkout. It does not show up on Invoices. Maximum length
        /// of 250 characters.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of this rate card's most recently created version.
        /// </summary>
        [JsonProperty("latest_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("latest_version")]
#endif
        public string LatestVersion { get; set; }

        /// <summary>
        /// The ID of the Rate Card Version that will be used by all subscriptions when no specific
        /// version is specified.
        /// </summary>
        [JsonProperty("live_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("live_version")]
#endif
        public string LiveVersion { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular RateCard. Maximum length of 200
        /// characters.
        /// </summary>
        [JsonProperty("lookup_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_key")]
#endif
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The interval for assessing service. For example, a monthly Rate Card with a rate of $1
        /// for the first 10 "workloads" and $2 thereafter means "$1 per workload up to 10 workloads
        /// during a month of service." This is similar to but distinct from billing interval; the
        /// service interval deals with the rate at which the customer accumulates fees, while the
        /// billing interval in Cadence deals with the rate the customer is billed.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("service_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_interval")]
#endif
        public string ServiceInterval { get; set; }

        /// <summary>
        /// The length of the interval for assessing service. For example, set this to 3 and
        /// <c>service_interval</c> to <c>"month"</c> in order to specify quarterly service.
        /// </summary>
        [JsonProperty("service_interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_interval_count")]
#endif
        public long ServiceIntervalCount { get; set; }

        /// <summary>
        /// The Stripe Tax tax behavior - whether the rates are inclusive or exclusive of tax.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }
    }
}
