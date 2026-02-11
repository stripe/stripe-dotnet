// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.RateCards
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomPricingUnitOverageRateCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The ID of the custom pricing unit this overage rate applies to.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public string CustomPricingUnit { get; set; }

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
        /// The ID of the one-time item to use for overage line items.
        /// </summary>
        [JsonProperty("one_time_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("one_time_item")]
#endif
        public string OneTimeItem { get; set; }

        /// <summary>
        /// The per-unit amount to charge for overages, represented as a decimal string in minor
        /// currency units with at most 12 decimal places.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public string UnitAmount { get; set; }
    }
}
