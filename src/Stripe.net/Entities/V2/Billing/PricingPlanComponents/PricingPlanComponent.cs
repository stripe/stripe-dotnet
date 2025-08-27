// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PricingPlanComponent : StripeEntity<PricingPlanComponent>, IHasId, IHasMetadata, IHasObject
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
        /// Time at which the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Details if this component is a License Fee.
        /// </summary>
        [JsonProperty("license_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee")]
#endif
        public PricingPlanComponentLicenseFee LicenseFee { get; set; }

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
        /// An internal key you can use to search for a particular PricingPlanComponent.
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
        /// The ID of the Pricing Plan this component belongs to.
        /// </summary>
        [JsonProperty("pricing_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan")]
#endif
        public string PricingPlan { get; set; }

        /// <summary>
        /// The ID of the Pricing Plan Version this component belongs to.
        /// </summary>
        [JsonProperty("pricing_plan_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_plan_version")]
#endif
        public string PricingPlanVersion { get; set; }

        /// <summary>
        /// Details if this component is a Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public PricingPlanComponentRateCard RateCard { get; set; }

        /// <summary>
        /// Details if this component is a Service Action.
        /// </summary>
        [JsonProperty("service_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_action")]
#endif
        public PricingPlanComponentServiceAction ServiceAction { get; set; }

        /// <summary>
        /// The type of the PricingPlanComponent.
        /// One of: <c>license_fee</c>, <c>rate_card</c>, or <c>service_action</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
