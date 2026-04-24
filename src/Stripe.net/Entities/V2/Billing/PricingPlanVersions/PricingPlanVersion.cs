// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Pricing Plan Version represents a specific configuration of a Pricing Plan at a point
    /// in time. Versions are created automatically when you update a Pricing Plan, allowing you
    /// to track changes and manage which version is active for new subscriptions. Each version
    /// has a start date and optionally an end date if it has been superseded.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanVersion : StripeEntity<PricingPlanVersion>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when this version became inactive. null if it's the latest version.
        /// </summary>
        [JsonProperty("end_date")]
        [STJS.JsonPropertyName("end_date")]
        public DateTime? EndDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ID of the PricingPlan this version belongs to.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// The timestamp when this version became active.
        /// </summary>
        [JsonProperty("start_date")]
        [STJS.JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
