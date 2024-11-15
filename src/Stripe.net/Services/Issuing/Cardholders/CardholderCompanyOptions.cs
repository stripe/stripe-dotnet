// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The entity's business ID number.
        /// </summary>
        [JsonProperty("tax_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id")]
#endif

        public string TaxId { get; set; }
    }
}
