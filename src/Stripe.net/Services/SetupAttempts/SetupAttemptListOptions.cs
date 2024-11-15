// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupAttemptListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return SetupAttempts created by the SetupIntent specified by this ID.
        /// </summary>
        [JsonProperty("setup_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("setup_intent")]
#endif

        public string SetupIntent { get; set; }
    }
}
