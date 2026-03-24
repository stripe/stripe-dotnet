// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectInputsInputSelectionChoice : StripeEntity<ReaderActionCollectInputsInputSelectionChoice>, IHasId
    {
        /// <summary>
        /// The identifier for the selected choice. Maximum 50 characters.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The button style for the choice. Can be <c>primary</c> or <c>secondary</c>.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
        [STJS.JsonPropertyName("style")]
        public string Style { get; set; }

        /// <summary>
        /// The text to be selected. Maximum 30 characters.
        /// </summary>
        [JsonProperty("text")]
        [STJS.JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
