// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Pricing Plan Component represents an individual billing element within a Pricing Plan.
    /// Components can be Rate Cards for usage-based charges, License Fees for recurring fixed
    /// charges, or Service Actions for recurring credit grants. Each component is associated
    /// with a specific version of the Pricing Plan and defines one aspect of how customers are
    /// billed.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PricingPlanComponent : StripeEntity<PricingPlanComponent>, IHasId, IHasMetadata, IHasObject
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
        /// Details if this component is a License Fee.
        /// </summary>
        [JsonProperty("license_fee")]
        [STJS.JsonPropertyName("license_fee")]
        public PricingPlanComponentLicenseFee LicenseFee { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular PricingPlanComponent.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan this component belongs to.
        /// </summary>
        [JsonProperty("pricing_plan")]
        [STJS.JsonPropertyName("pricing_plan")]
        public string PricingPlan { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Version this component belongs to.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
        [STJS.JsonPropertyName("pricing_plan_version")]
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Details if this component is a Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public PricingPlanComponentRateCard RateCard { get; set; }

        /// <summary>
        /// Details if this component is a Service Action.
        /// </summary>
        [JsonProperty("service_action")]
        [STJS.JsonPropertyName("service_action")]
        public PricingPlanComponentServiceAction ServiceAction { get; set; }

        /// <summary>
        /// The type of the PricingPlanComponent.
        /// One of: <c>license_fee</c>, <c>rate_card</c>, or <c>service_action</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
