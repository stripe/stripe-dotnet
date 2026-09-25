// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentEstimatedFeeNetworkFeeDetailsNetworkOptionsAch : StripeEntity<PayoutIntentEstimatedFeeNetworkFeeDetailsNetworkOptionsAch>
    {
        /// <summary>
        /// Open Enum. ACH submission timing.
        /// One of: <c>next_day</c>, or <c>same_day</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("submission")]
        [STJS.JsonPropertyName("submission")]
        public string Submission { get; set; }
    }
}
