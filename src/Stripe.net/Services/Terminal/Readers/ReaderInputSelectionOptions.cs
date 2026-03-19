// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderInputSelectionOptions : INestedOptions
    {
        /// <summary>
        /// List of choices for the <c>selection</c> input.
        /// </summary>
        [JsonProperty("choices")]
        [STJS.JsonPropertyName("choices")]
        public List<ReaderInputSelectionChoiceOptions> Choices { get; set; }
    }
}
