// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputSelectionChoice : StripeEntity<ReaderActionCollectInputsInputSelectionChoice>
    {
        /// <summary>
        /// The button style for the choice.
        /// One of: <c>primary</c>, or <c>secondary</c>.
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }

        /// <summary>
        /// A value to be selected.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
