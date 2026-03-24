// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterEventAdjustmentCancel : StripeEntity<MeterEventAdjustmentCancel>
    {
        /// <summary>
        /// Unique identifier for the event.
        /// </summary>
        [JsonProperty("identifier")]
        [STJS.JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }
}
