// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountDocumentsProofOfRegistrationSignerOptions : INestedOptions
    {
        /// <summary>
        /// The token of the person signing the document, if applicable.
        /// </summary>
        [JsonProperty("person")]
        [STJS.JsonPropertyName("person")]
        public string Person { get; set; }
    }
}
