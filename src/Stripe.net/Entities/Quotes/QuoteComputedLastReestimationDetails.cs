// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteComputedLastReestimationDetails : StripeEntity<QuoteComputedLastReestimationDetails>
    {
        /// <summary>
        /// When <c>status</c> is <c>failed</c>, provides details about the quote reestimation
        /// failure.
        /// </summary>
        [JsonProperty("failed")]
        public QuoteComputedLastReestimationDetailsFailed Failed { get; set; }

        /// <summary>
        /// Latest status of the reestimation.
        /// One of: <c>failed</c>, <c>in_progress</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
