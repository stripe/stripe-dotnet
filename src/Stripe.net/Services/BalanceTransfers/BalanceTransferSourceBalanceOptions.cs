// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceTransferSourceBalanceOptions : INestedOptions
    {
        [JsonProperty("allocated_funds")]
        [STJS.JsonPropertyName("allocated_funds")]
        public BalanceTransferSourceBalanceAllocatedFundsOptions AllocatedFunds { get; set; }

        /// <summary>
        /// Source balance type to pull funds from for the Balance Transfer.
        /// One of: <c>allocated_funds</c>, <c>issuing</c>, or <c>payments</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
