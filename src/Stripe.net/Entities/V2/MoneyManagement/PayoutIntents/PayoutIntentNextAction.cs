// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentNextAction : StripeEntity<PayoutIntentNextAction>
    {
        /// <summary>
        /// Details about a failure that requires user action. Populated when type is
        /// handle_failure.
        /// </summary>
        [JsonProperty("handle_failure")]
        [STJS.JsonPropertyName("handle_failure")]
        public PayoutIntentNextActionHandleFailure HandleFailure { get; set; }

        /// <summary>
        /// Open Enum. The type of next action required.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
