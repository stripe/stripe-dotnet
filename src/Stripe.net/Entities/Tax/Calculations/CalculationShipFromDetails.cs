// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CalculationShipFromDetails : StripeEntity<CalculationShipFromDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public CalculationShipFromDetailsAddress Address { get; set; }
    }
}
