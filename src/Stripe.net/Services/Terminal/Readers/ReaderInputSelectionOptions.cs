// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderInputSelectionOptions : INestedOptions
    {
        /// <summary>
        /// List of choices for the <c>selection</c> input.
        /// </summary>
        [JsonProperty("choices")]
        public List<ReaderInputSelectionChoiceOptions> Choices { get; set; }
    }
}
