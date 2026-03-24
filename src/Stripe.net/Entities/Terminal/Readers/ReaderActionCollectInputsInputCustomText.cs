// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectInputsInputCustomText : StripeEntity<ReaderActionCollectInputsInputCustomText>
    {
        /// <summary>
        /// Customize the default description for this input.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Customize the default label for this input's skip button.
        /// </summary>
        [JsonProperty("skip_button")]
        [STJS.JsonPropertyName("skip_button")]
        public string SkipButton { get; set; }

        /// <summary>
        /// Customize the default label for this input's submit button.
        /// </summary>
        [JsonProperty("submit_button")]
        [STJS.JsonPropertyName("submit_button")]
        public string SubmitButton { get; set; }

        /// <summary>
        /// Customize the default title for this input.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
