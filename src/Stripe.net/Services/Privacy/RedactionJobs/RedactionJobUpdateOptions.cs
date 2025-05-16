// File generated from our OpenAPI spec
namespace Stripe.Privacy
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RedactionJobUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Determines the validation behavior of the job. Default is <c>error</c>.
        /// One of: <c>error</c>, or <c>fix</c>.
        /// </summary>
        [JsonProperty("validation_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validation_behavior")]
#endif
        public string ValidationBehavior { get; set; }
    }
}
