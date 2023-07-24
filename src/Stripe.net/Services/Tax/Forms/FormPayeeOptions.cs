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
        /// Specifies the payee type. Always <c>account</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
