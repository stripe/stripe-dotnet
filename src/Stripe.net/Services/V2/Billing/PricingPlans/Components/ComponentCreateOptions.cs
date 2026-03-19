// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.PricingPlans
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ComponentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details if this component is a License Fee.
        /// </summary>
        [JsonProperty("license_fee")]
        [STJS.JsonPropertyName("license_fee")]
        public ComponentCreateLicenseFeeOptions LicenseFee { get; set; }

        /// <summary>
        /// An identifier that can be used to find this component.
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
        /// Details if this component is a Rate Card.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public ComponentCreateRateCardOptions RateCard { get; set; }

        /// <summary>
        /// Details if this component is a Service Action.
        /// </summary>
        [JsonProperty("service_action")]
        [STJS.JsonPropertyName("service_action")]
        public ComponentCreateServiceActionOptions ServiceAction { get; set; }

        /// <summary>
        /// The type of the PricingPlanComponent.
        /// One of: <c>license_fee</c>, <c>rate_card</c>, or <c>service_action</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
