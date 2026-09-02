// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FeedbackOptionUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The text of the feedback option, which customers see when canceling. Maximum 100
        /// characters.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
