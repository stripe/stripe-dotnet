// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextAction : StripeEntity<FundingIntentNextAction>
    {
        /// <summary>
        /// Details for handling a failed attempt.
        /// </summary>
        [JsonProperty("handle_failure")]
        [STJS.JsonPropertyName("handle_failure")]
        public FundingIntentNextActionHandleFailure HandleFailure { get; set; }

        /// <summary>
        /// The reason that you must provide a different check.
        /// </summary>
        [JsonProperty("provide_new_check")]
        [STJS.JsonPropertyName("provide_new_check")]
        public FundingIntentNextActionProvideNewCheck ProvideNewCheck { get; set; }

        /// <summary>
        /// Issues that require corrected check images or an updated amount.
        /// </summary>
        [JsonProperty("provide_new_images")]
        [STJS.JsonPropertyName("provide_new_images")]
        public FundingIntentNextActionProvideNewImages ProvideNewImages { get; set; }

        /// <summary>
        /// The type of action required.
        /// One of: <c>handle_failure</c>, <c>provide_new_check</c>, <c>provide_new_images</c>, or
        /// <c>requires_check_images</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
