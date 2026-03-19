// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenAccountCompanyVerificationOptions : INestedOptions
    {
        /// <summary>
        /// A document verifying the business.
        /// </summary>
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public TokenAccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
