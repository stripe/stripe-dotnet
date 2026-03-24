// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectInputsInputToggle : StripeEntity<ReaderActionCollectInputsInputToggle>
    {
        /// <summary>
        /// The toggle's default value. Can be <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
        [STJS.JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The toggle's description text. Maximum 50 characters.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The toggle's title text. Maximum 50 characters.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The toggle's collected value. Can be <c>enabled</c> or <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
