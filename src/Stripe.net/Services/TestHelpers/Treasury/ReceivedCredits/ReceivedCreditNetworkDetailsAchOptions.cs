// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// ACH Addenda record.
        /// </summary>
        [JsonProperty("addenda")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("addenda")]
#endif
        public string Addenda { get; set; }
    }
}
