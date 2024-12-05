// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputToggle : StripeEntity<ReaderActionCollectInputsInputToggle>
    {
        /// <summary>
        /// The toggle's default value.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The toggle's description text.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The toggle's title text.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The toggle's collected value.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
