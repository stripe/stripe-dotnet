// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundNextAction : StripeEntity<RefundNextAction>
    {
        [JsonProperty("display_details")]
        public RefundNextActionDisplayDetails DisplayDetails { get; set; }

        /// <summary>
        /// Type of the next action to perform.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
