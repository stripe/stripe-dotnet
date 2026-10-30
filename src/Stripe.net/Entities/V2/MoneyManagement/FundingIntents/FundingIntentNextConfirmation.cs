// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextConfirmation : StripeEntity<FundingIntentNextConfirmation>
    {
        /// <summary>
        /// Factors to review before confirming the FundingIntent.
        /// </summary>
        [JsonProperty("requires_review")]
        [STJS.JsonPropertyName("requires_review")]
        public FundingIntentNextConfirmationRequiresReview RequiresReview { get; set; }

        /// <summary>
        /// The type of confirmation required.
        /// One of: <c>requires_review</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
