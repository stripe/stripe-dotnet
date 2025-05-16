// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderSucceedInputCollectionOptions : BaseOptions
    {
        /// <summary>
        /// This parameter defines the skip behavior for input collection.
        /// One of: <c>all</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("skip_non_required_inputs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_non_required_inputs")]
#endif
        public string SkipNonRequiredInputs { get; set; }
    }
}
