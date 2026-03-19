// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2BillingRateCardCustomPricingUnitOverageRateCreatedEventData : StripeEntity<V2BillingRateCardCustomPricingUnitOverageRateCreatedEventData>
    {
        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the custom pricing unit this overage rate applies to.
        /// </summary>
        [JsonProperty("custom_pricing_unit")]
        [STJS.JsonPropertyName("custom_pricing_unit")]
        public string CustomPricingUnit { get; set; }

        /// <summary>
        /// The ID of the RateCard which this custom pricing unit overage rate belongs to.
        /// </summary>
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        /// <summary>
        /// The ID of the RateCard Version when the custom pricing unit overage rate was created.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }
    }
}
