// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderInputSelectionChoiceOptions : INestedOptions
    {
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
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
