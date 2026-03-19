// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardholderIndividualVerificationOptions : INestedOptions
    {
        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        [STJS.JsonPropertyName("document")]
        public CardholderIndividualVerificationDocumentOptions Document { get; set; }
    }
}
