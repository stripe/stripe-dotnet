// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMandateAcceptanceOfflineOptions : INestedOptions
    {
        /// <summary>
        /// An email to contact you with if a copy of the mandate is requested, required if
        /// <c>type</c> is <c>offline</c>.
        /// </summary>
        [JsonProperty("contact_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("contact_email")]
#endif
        public string ContactEmail { get; set; }
    }
}
