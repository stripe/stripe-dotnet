// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputCustomText : StripeEntity<ReaderActionCollectInputsInputCustomText>
    {
        /// <summary>
        /// Customize the default description for this input.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Customize the default label for this input's skip button.
        /// </summary>
        [JsonProperty("skip_button")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skip_button")]
#endif
        public string SkipButton { get; set; }

        /// <summary>
        /// Customize the default label for this input's submit button.
        /// </summary>
        [JsonProperty("submit_button")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("submit_button")]
#endif
        public string SubmitButton { get; set; }

        /// <summary>
        /// Customize the default title for this input.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }
    }
}
