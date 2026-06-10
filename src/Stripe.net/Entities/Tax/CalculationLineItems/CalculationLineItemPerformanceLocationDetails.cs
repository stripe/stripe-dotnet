// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CalculationLineItemPerformanceLocationDetails : StripeEntity<CalculationLineItemPerformanceLocationDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public CalculationLineItemPerformanceLocationDetailsAddress Address { get; set; }
    }
}
