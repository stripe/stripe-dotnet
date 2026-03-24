// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenPiiOptions : INestedOptions
    {
        /// <summary>
        /// The <c>id_number</c> for the PII, in string form.
        /// </summary>
        [JsonProperty("id_number")]
        [STJS.JsonPropertyName("id_number")]
        public string IdNumber { get; set; }
    }
}
