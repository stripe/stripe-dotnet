// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextActionHandleFailure : StripeEntity<FundingIntentNextActionHandleFailure>
    {
        /// <summary>
        /// The reason the attempt failed.
        /// One of: <c>insufficient_funds</c>, <c>not_authorized</c>, or <c>stripe_rejected</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Whether you can retry the FundingIntent.
        /// </summary>
        [JsonProperty("retryable")]
        [STJS.JsonPropertyName("retryable")]
        public bool Retryable { get; set; }
    }
}
