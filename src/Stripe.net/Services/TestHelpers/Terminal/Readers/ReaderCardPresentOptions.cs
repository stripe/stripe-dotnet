// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
