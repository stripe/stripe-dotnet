// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountNoticeListOptions : ListOptions
    {
        /// <summary>
        /// Set to false to only return unsent AccountNotices.
        /// </summary>
        [JsonProperty("sent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sent")]
#endif
        public bool? Sent { get; set; }
    }
}
