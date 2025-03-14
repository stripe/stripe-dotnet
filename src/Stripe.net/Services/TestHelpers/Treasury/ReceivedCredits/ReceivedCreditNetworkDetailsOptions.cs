// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ach")]
#endif
        public ReceivedCreditNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
