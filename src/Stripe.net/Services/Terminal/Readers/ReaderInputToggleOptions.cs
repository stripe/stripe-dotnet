// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderInputToggleOptions : INestedOptions
    {
        /// <summary>
        /// The default value of the toggle.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The description which will be displayed for the toggle.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The title which will be displayed for the toggle.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
