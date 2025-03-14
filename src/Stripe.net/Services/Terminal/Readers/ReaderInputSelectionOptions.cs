// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderInputSelectionOptions : INestedOptions
    {
        /// <summary>
        /// List of choices for the <c>selection</c> input.
        /// </summary>
        [JsonProperty("choices")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("choices")]
#endif
        public List<ReaderInputSelectionChoiceOptions> Choices { get; set; }
    }
}
