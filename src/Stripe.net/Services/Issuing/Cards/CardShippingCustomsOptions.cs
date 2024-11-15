// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardShippingCustomsOptions : INestedOptions
    {
        /// <summary>
        /// The Economic Operators Registration and Identification (EORI) number to use for Customs.
        /// Required for bulk shipments to Europe.
        /// </summary>
        [JsonProperty("eori_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eori_number")]
#endif

        public string EoriNumber { get; set; }
    }
}
