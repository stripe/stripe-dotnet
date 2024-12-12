// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApplicationFeeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return application fees for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }
    }
}
