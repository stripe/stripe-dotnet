// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class BalanceTransferSourceBalance : StripeEntity<BalanceTransferSourceBalance>
    {
        [JsonProperty("issuing")]
        [STJS.JsonPropertyName("issuing")]
        public BalanceTransferSourceBalanceIssuing Issuing { get; set; }

        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public BalanceTransferSourceBalancePayments Payments { get; set; }

        /// <summary>
        /// Source balance type to adjust for the Balance Transfer. One of <c>payments</c>,
        /// <c>issuing</c>, or <c>allocated_funds</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
