// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CertificateListOptions : ListOptions
    {
        /// <summary>
        /// The ID of an existing tax exemption.
        /// </summary>
        [JsonProperty("tax_exemption")]
        [STJS.JsonPropertyName("tax_exemption")]
        public string TaxExemption { get; set; }
    }
}
