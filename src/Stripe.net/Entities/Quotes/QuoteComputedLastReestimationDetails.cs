// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteComputedLastReestimationDetails : StripeEntity<QuoteComputedLastReestimationDetails>
    {
        /// <summary>
        /// When <c>status</c> is <c>failed</c>, provides details about the quote reestimation
        /// failure.
        /// </summary>
        [JsonProperty("failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed")]
#endif
        public QuoteComputedLastReestimationDetailsFailed Failed { get; set; }

        /// <summary>
        /// Latest status of the reestimation.
        /// One of: <c>failed</c>, <c>in_progress</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
