// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2BillingRateCardCustomPricingUnitOverageRateCreatedEventData : StripeEntity<V2BillingRateCardCustomPricingUnitOverageRateCreatedEventData>
    {
        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the custom pricing unit this overage rate applies to.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_pricing_unit")]
#endif
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// The ID of the RateCard which this custom pricing unit overage rate belongs to.
        /// </summary>
        [JsonProperty("rate_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card")]
#endif
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the RateCard Version when the custom pricing unit overage rate was created.
        /// </summary>
        [JsonProperty("rate_card_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_card_version")]
#endif
        public string RateCardVersion { get; set; }
    }
}
