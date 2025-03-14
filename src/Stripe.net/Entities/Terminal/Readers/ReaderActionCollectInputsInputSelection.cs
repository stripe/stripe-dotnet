// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputSelection : StripeEntity<ReaderActionCollectInputsInputSelection>
    {
        /// <summary>
        /// List of possible choices to be selected.
        /// </summary>
        [JsonProperty("choices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("choices")]
#endif
        public List<ReaderActionCollectInputsInputSelectionChoice> Choices { get; set; }

        /// <summary>
        /// The value of the selected choice.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
