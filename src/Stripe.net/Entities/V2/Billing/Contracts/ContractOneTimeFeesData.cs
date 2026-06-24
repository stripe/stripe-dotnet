// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractOneTimeFeesData : StripeEntity<ContractOneTimeFeesData>, IHasId
    {
        /// <summary>
        /// The amount billed for this fee.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// When this fee will be billed. Always contains a concrete timestamp.
        /// </summary>
        [JsonProperty("bill_at")]
        [STJS.JsonPropertyName("bill_at")]
        public ContractOneTimeFeesDataBillAt BillAt { get; set; }

        /// <summary>
        /// The ID of the one-time fee.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The user-provided lookup key.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// The ID of the v1 Product for this fee.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }
    }
}
