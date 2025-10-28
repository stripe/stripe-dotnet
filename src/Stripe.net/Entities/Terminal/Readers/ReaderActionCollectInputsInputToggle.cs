// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputToggle : StripeEntity<ReaderActionCollectInputsInputToggle>
    {
        /// <summary>
        /// The toggle's default value. Can be <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_value")]
#endif
        public string DefaultValue { get; set; }

        /// <summary>
        /// The toggle's description text. Maximum 50 characters.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The toggle's title text. Maximum 50 characters.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }

        /// <summary>
        /// The toggle's collected value. Can be <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
