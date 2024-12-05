// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingCustomsOptions : INestedOptions
    {
        /// <summary>
        /// The Economic Operators Registration and Identification (EORI) number to use for Customs.
        /// Required for bulk shipments to Europe.
        /// </summary>
        [JsonProperty("eori_number")]
        public string EoriNumber { get; set; }
    }
}
