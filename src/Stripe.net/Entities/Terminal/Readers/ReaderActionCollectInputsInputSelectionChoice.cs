// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputSelectionChoice : StripeEntity<ReaderActionCollectInputsInputSelectionChoice>
    {
        /// <summary>
        /// The button style for the choice.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("style")]
#endif
        public string Style { get; set; }

        /// <summary>
        /// A value to be selected.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
