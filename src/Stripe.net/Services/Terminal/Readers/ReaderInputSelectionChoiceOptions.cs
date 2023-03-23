// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderInputSelectionChoiceOptions : INestedOptions
    {
        /// <summary>
        /// The style of the button which will be shown for this choice.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <summary>
        /// The text which will be shown on the button for this choice.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
