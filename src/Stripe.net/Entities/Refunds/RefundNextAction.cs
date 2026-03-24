// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RefundNextAction : StripeEntity<RefundNextAction>
    {
        [JsonProperty("display_details")]
        [STJS.JsonPropertyName("display_details")]
        public RefundNextActionDisplayDetails DisplayDetails { get; set; }

        /// <summary>
        /// Type of the next action to perform.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
