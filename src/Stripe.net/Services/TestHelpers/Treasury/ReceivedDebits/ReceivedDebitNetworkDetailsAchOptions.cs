// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Addenda record data associated with this ReceivedDebit.
        /// </summary>
        [JsonProperty("addenda")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("addenda")]
#endif
        public string Addenda { get; set; }
    }
}
