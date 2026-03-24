// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceCreateBillingCycleDayTimeOptions : INestedOptions
    {
        /// <summary>
        /// The hour at which the billing cycle ends. This must be an integer between 0 and 23,
        /// inclusive. 0 represents midnight, and 23 represents 11 PM.
        /// </summary>
        [JsonProperty("hour")]
        [STJS.JsonPropertyName("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// The minute at which the billing cycle ends. Must be an integer between 0 and 59,
        /// inclusive.
        /// </summary>
        [JsonProperty("minute")]
        [STJS.JsonPropertyName("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// The second at which the billing cycle ends. Must be an integer between 0 and 59,
        /// inclusive.
        /// </summary>
        [JsonProperty("second")]
        [STJS.JsonPropertyName("second")]
        public long? Second { get; set; }
    }
}
