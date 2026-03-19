// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
        [STJS.JsonPropertyName("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
