// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionLineItemPerformanceLocationDetails : StripeEntity<TransactionLineItemPerformanceLocationDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public TransactionLineItemPerformanceLocationDetailsAddress Address { get; set; }
    }
}
