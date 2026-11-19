// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class GroupCreateGroupingBehaviorByCadenceDayTimeOptions : INestedOptions
    {
        /// <summary>
        /// The hour, from 0 through 23.
        /// </summary>
        [JsonProperty("hour")]
        [STJS.JsonPropertyName("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// The minute, from 0 through 59.
        /// </summary>
        [JsonProperty("minute")]
        [STJS.JsonPropertyName("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// The second, from 0 through 59.
        /// </summary>
        [JsonProperty("second")]
        [STJS.JsonPropertyName("second")]
        public long? Second { get; set; }
    }
}
