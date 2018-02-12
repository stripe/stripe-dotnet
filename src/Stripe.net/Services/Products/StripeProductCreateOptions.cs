using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductCreateOptions : StripeProductSharedOptions
    {
        /// <summary>
        /// The identifier for the product. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }
}
