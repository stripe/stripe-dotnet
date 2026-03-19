// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressCreditOptions : BaseOptions
    {
        /// <summary>
        /// Object containing the amount value and currency to credit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Open Enum. The network to use in simulating the funds flow. This will be the reflected
        /// in the resulting ReceivedCredit.
        /// One of: <c>ach</c>, <c>fps</c>, <c>rtp</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// String explaining funds flow. Use this field to populate the statement descriptor of the
        /// ReceivedCredit created as an eventual result of this simulation.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
