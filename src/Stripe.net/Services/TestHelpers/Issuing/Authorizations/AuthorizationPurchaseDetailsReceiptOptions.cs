// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationPurchaseDetailsReceiptOptions : INestedOptions
    {
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("total")]
        [STJS.JsonPropertyName("total")]
        public long? Total { get; set; }

        [JsonProperty("unit_cost")]
        [STJS.JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
