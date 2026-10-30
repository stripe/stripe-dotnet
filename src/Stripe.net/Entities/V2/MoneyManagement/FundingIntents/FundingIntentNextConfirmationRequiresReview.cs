// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextConfirmationRequiresReview : StripeEntity<FundingIntentNextConfirmationRequiresReview>
    {
        /// <summary>
        /// Factors that require review.
        /// </summary>
        [JsonProperty("factors")]
        [STJS.JsonPropertyName("factors")]
        public List<FundingIntentNextConfirmationRequiresReviewFactor> Factors { get; set; }
    }
}
