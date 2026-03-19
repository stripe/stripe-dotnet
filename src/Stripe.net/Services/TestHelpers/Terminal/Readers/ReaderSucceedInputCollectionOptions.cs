// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderSucceedInputCollectionOptions : BaseOptions
    {
        /// <summary>
        /// This parameter defines the skip behavior for input collection.
        /// One of: <c>all</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("skip_non_required_inputs")]
        [STJS.JsonPropertyName("skip_non_required_inputs")]
        public string SkipNonRequiredInputs { get; set; }
    }
}
