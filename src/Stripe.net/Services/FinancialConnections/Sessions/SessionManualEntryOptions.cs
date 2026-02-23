// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionManualEntryOptions : INestedOptions
    {
        /// <summary>
        /// How manual entry should be handled.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mode")]
#endif
        public string Mode { get; set; }
    }
}
