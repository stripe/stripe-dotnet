// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputSelectionChoice : StripeEntity<ReaderActionCollectInputsInputSelectionChoice>, IHasId
    {
        /// <summary>
        /// The identifier for the selected choice. Maximum 50 characters.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The button style for the choice. Can be <c>primary</c> or <c>secondary</c>.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("style")]
#endif
        public string Style { get; set; }

        /// <summary>
        /// The text to be selected. Maximum 30 characters.
        /// </summary>
        [JsonProperty("text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("text")]
#endif
        public string Text { get; set; }
    }
}
