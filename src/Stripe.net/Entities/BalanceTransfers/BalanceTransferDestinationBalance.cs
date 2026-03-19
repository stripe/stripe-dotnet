// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceTransferDestinationBalance : StripeEntity<BalanceTransferDestinationBalance>
    {
        [JsonProperty("issuing")]
        [STJS.JsonPropertyName("issuing")]
        public BalanceTransferDestinationBalanceIssuing Issuing { get; set; }

        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public BalanceTransferDestinationBalancePayments Payments { get; set; }

        /// <summary>
        /// Destination balance type to adjust for the Balance Transfer. One of <c>payments</c>,
        /// <c>issuing</c>, or <c>allocated_funds</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
