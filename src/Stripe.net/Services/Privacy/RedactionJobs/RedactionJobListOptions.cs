// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RedactionJobListOptions : ListOptions
    {
        /// <summary>
        /// One of: <c>canceled</c>, <c>canceling</c>, <c>created</c>, <c>failed</c>, <c>ready</c>,
        /// <c>redacting</c>, <c>succeeded</c>, or <c>validating</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
