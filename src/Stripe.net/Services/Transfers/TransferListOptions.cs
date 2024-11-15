// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransferListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return transfers for the destination specified by this account ID.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif

        public string Destination { get; set; }

        /// <summary>
        /// Only return transfers with the specified transfer group.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif

        public string TransferGroup { get; set; }
    }
}
