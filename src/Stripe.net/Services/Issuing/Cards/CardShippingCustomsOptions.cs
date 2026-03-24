// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardShippingCustomsOptions : INestedOptions
    {
        /// <summary>
        /// The Economic Operators Registration and Identification (EORI) number to use for Customs.
        /// Required for bulk shipments to Europe.
        /// </summary>
        [JsonProperty("eori_number")]
        [STJS.JsonPropertyName("eori_number")]
        public string EoriNumber { get; set; }
    }
}
