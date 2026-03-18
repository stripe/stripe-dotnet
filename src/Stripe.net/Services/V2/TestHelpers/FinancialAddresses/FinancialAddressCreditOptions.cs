// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressCreditOptions : BaseOptions
    {
        /// <summary>
        /// Object containing the amount value and currency to credit.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Open Enum. The network to use in simulating the funds flow. This will be the reflected
        /// in the resulting ReceivedCredit.
        /// One of: <c>ach</c>, <c>fps</c>, <c>rtp</c>, <c>sepa_credit_transfer</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif
        public string Network { get; set; }

        /// <summary>
        /// String explaining funds flow. Use this field to populate the statement descriptor of the
        /// ReceivedCredit created as an eventual result of this simulation.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
