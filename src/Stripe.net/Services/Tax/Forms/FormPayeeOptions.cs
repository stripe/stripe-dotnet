// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormPayeeOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose forms will be retrieved.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The external reference to the payee whose forms will be retrieved.
        /// </summary>
        [JsonProperty("external_reference")]
        [STJS.JsonPropertyName("external_reference")]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Specifies the payee type. Either <c>account</c> or <c>external_reference</c>.
        /// One of: <c>account</c>, or <c>external_reference</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
