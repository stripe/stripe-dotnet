// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class FormPayeeOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose forms will be retrieved.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The external reference to the payee whose forms will be retrieved.
        /// </summary>
        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Specifies the payee type. Either <c>account</c> or <c>external_reference</c>.
        /// One of: <c>account</c>, or <c>external_reference</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
