// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCustomerAutomaticIndirectTaxOptions : INestedOptions
    {
        /// <summary>
        /// Describes the customer's tax exemption status, which is <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When set to reverse, invoice and receipt PDFs include the following
        /// text: “Reverse charge”.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("exempt")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exempt")]
#endif
        public string Exempt { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }
    }
}
