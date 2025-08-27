// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ComponentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details if this component is a License Fee.
        /// </summary>
        [JsonProperty("license_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("license_fee")]
#endif
        public ComponentCreateLicenseFeeOptions LicenseFee { get; set; }

        /// <summary>
        /// An identifier that can be used to find this component.
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
        /// Details if this component is a Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public ComponentCreateRateCardOptions RateCard { get; set; }

        /// <summary>
        /// Details if this component is a Service Action.
        /// </summary>
        [JsonProperty("service_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_action")]
#endif
        public ComponentCreateServiceActionOptions ServiceAction { get; set; }

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
