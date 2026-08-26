// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FeedbackOptionCreateOptions : BaseOptions
    {
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
