// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using Newtonsoft.Json;

    public class ReaderCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// Card Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
