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
        /// The ID of a <a href="https://stripe.com/api/files/object">file</a> uploaded with purpose
        /// <c>tax_certificate</c>. The file must belong to the same account and mode as the tax
        /// exemption. You can't use a deleted file or a file attached to another certificate that
        /// hasn't been deleted.
        /// </summary>
        [JsonProperty("file")]
        [STJS.JsonPropertyName("file")]
        public string File { get; set; }

        /// <summary>
        /// The ID of an existing <a href="https://stripe.com/api/tax/exemptions/object">customer
        /// tax exemption</a> that hasn't been deleted.
        /// </summary>
        [JsonProperty("tax_exemption")]
        [STJS.JsonPropertyName("tax_exemption")]
        public string TaxExemption { get; set; }
    }
}
