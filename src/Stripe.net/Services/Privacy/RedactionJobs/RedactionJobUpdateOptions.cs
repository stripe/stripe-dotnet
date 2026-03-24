// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RedactionJobUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Determines the validation behavior of the job. Default is <c>error</c>.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
        [STJS.JsonPropertyName("validation_behavior")]
        public string ValidationBehavior { get; set; }
    }
}
