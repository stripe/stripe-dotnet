// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderInputSelectionChoiceOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The unique identifier for this choice.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The style of the button which will be shown for this choice. Can be <c>primary</c> or
        /// <c>secondary</c>.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
        [STJS.JsonPropertyName("style")]
        public string Style { get; set; }

        /// <summary>
        /// The text which will be shown on the button for this choice.
        /// </summary>
        [JsonProperty("text")]
        [STJS.JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
