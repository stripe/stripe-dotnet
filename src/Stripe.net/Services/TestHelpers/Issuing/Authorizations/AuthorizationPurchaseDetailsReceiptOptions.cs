// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPurchaseDetailsReceiptOptions : INestedOptions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        [JsonProperty("total")]
        public long? Total { get; set; }

        [JsonProperty("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
