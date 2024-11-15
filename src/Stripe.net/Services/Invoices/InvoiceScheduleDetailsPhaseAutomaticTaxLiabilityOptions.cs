// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsPhaseAutomaticTaxLiabilityOptions : INestedOptions
    {
        /// <summary>
        /// The connected account being referenced when <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif

        public string Account { get; set; }

        /// <summary>
        /// Type of the account referenced in the request.
        /// One of: <c>account</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
