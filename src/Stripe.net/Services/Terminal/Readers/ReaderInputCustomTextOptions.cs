// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderInputCustomTextOptions : INestedOptions
    {
        /// <summary>
        /// The description which will be displayed when collecting this input.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The skip button text.
        /// </summary>
        [JsonProperty("skip_button")]
        public string SkipButton { get; set; }

        /// <summary>
        /// The submit button text.
        /// </summary>
        [JsonProperty("submit_button")]
        public string SubmitButton { get; set; }

        /// <summary>
        /// The title which will be displayed when collecting this input.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
