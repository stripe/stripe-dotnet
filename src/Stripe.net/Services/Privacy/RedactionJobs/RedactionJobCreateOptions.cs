// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RedactionJobCreateOptions : BaseOptions
    {
        /// <summary>
        /// The objects to redact. These root objects and their related ones will be validated for
        /// redaction.
        /// </summary>
        [JsonProperty("objects")]
        [STJS.JsonPropertyName("objects")]
        public RedactionJobObjectsOptions Objects { get; set; }

        /// <summary>
        /// Determines the validation behavior of the job. Default is <c>error</c>.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
        [STJS.JsonPropertyName("validation_behavior")]
        public string ValidationBehavior { get; set; }
    }
}
