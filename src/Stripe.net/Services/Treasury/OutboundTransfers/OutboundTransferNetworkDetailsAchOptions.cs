// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Addenda record data associated with this OutboundTransfer.
        /// </summary>
        [JsonProperty("addenda")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("addenda")]
#endif
        public string Addenda { get; set; }
    }
}
