// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderInputSelectionChoiceOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The unique identifier for this choice.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The style of the button which will be shown for this choice.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("style")]
#endif
        public string Style { get; set; }

        /// <summary>
        /// The text which will be shown on the button for this choice.
        /// </summary>
        [JsonProperty("text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("text")]
#endif
        public string Text { get; set; }
    }
}
