// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CertificateCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of a file uploaded with purpose <c>tax_certificate</c>.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// The ID of an existing tax exemption.
        /// </summary>
        [JsonProperty("tax_exemption")]
        [STJS.JsonPropertyName("tax_exemption")]
        public string TaxExemption { get; set; }
    }
}
