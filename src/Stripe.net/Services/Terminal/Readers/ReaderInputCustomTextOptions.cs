// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderInputCustomTextOptions : INestedOptions
    {
        /// <summary>
        /// The description which will be displayed when collecting this input.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Custom text for the skip button. Maximum 14 characters.
        /// </summary>
        [JsonProperty("skip_button")]
        [STJS.JsonPropertyName("skip_button")]
        public string SkipButton { get; set; }

        /// <summary>
        /// Custom text for the submit button. Maximum 30 characters.
        /// </summary>
        [JsonProperty("submit_button")]
        [STJS.JsonPropertyName("submit_button")]
        public string SubmitButton { get; set; }

        /// <summary>
        /// The title which will be displayed when collecting this input.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
