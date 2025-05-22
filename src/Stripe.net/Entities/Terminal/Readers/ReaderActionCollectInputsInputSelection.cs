// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInputSelection : StripeEntity<ReaderActionCollectInputsInputSelection>, IHasId
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
        /// The id of the selected choice.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The text of the selected choice.
        /// </summary>
        [JsonProperty("text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("text")]
#endif
        public string Text { get; set; }
    }
}
