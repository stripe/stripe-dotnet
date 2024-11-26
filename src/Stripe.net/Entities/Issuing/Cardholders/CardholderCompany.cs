// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_provided")]
#endif
        public bool TaxIdProvided { get; set; }
    }
}
