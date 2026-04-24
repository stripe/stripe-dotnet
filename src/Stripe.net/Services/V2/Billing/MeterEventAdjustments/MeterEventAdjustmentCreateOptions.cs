// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterEventAdjustmentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Specifies which event to cancel.
        /// </summary>
        [JsonProperty("cancel")]
        [STJS.JsonPropertyName("cancel")]
        public MeterEventAdjustmentCreateCancelOptions Cancel { get; set; }

        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
        [STJS.JsonPropertyName("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Specifies the type of cancellation. Currently supports canceling a single event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
