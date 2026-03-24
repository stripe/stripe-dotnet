// File generated from our OpenAPI spec
namespace Stripe.V2.Payments.SettlementAllocationIntents
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SplitListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter the SettlementAllocationIntentSplits by status.
        /// One of: <c>canceled</c>, <c>pending</c>, or <c>settled</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
