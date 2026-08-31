// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionOptions : INestedOptions
    {
        /// <summary>
        /// Dimension-based meter segment condition.
        /// </summary>
        [JsonProperty("dimension")]
        [STJS.JsonPropertyName("dimension")]
        public ServiceActionCreateCreditGrantPerTenantGrantConditionMeterEventFirstPerPeriodMeterSegmentConditionDimensionOptions Dimension { get; set; }

        /// <summary>
        /// The type of the meter segment condition. We currently support <c>dimension</c>.
        /// One of: <c>dimension</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
