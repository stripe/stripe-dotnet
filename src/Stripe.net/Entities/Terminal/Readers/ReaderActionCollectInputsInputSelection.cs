// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectInputsInputSelection : StripeEntity<ReaderActionCollectInputsInputSelection>, IHasId
    {
        /// <summary>
        /// List of possible choices to be selected.
        /// </summary>
        [JsonProperty("choices")]
        [STJS.JsonPropertyName("choices")]
        public List<ReaderActionCollectInputsInputSelectionChoice> Choices { get; set; }

        /// <summary>
        /// The id of the selected choice.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The text of the selected choice.
        /// </summary>
        [JsonProperty("text")]
        [STJS.JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
