// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceTransferSourceBalanceAllocatedFundsOptions : INestedOptions
    {
        /// <summary>
        /// The charge ID that the funds are originally sourced from. Required if <c>type</c> is
        /// <c>charge</c>.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// The type of object that the funds are originally sourced from. One of <c>charge</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
