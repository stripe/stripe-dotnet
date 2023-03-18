// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputSelection : StripeEntity<ReaderActionCollectInputsInputSelection>
    {
        /// <summary>
        /// List of possible choices to be selected.
        /// </summary>
        [JsonProperty("choices")]
        public List<ReaderActionCollectInputsInputSelectionChoice> Choices { get; set; }

        /// <summary>
        /// The value of the selected choice.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
