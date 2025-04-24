// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCustomerAutomaticIndirectTax : StripeEntity<AccountConfigurationCustomerAutomaticIndirectTax>
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

        /// <summary>
        /// The customer’s identified tax location - uses <c>location_source</c>. Will only be
        /// rendered if the <c>automatic_indirect_tax</c> feature is requested and <c>active</c>.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public AccountConfigurationCustomerAutomaticIndirectTaxLocation Location { get; set; }

        /// <summary>
        /// The data source used to identify the customer's tax location - defaults to
        /// 'identity_address'. Will only be used for automatic tax calculation on the customer's
        /// Invoices and Subscriptions.
        /// One of: <c>identity_address</c>, <c>ip_address</c>, or <c>shipping_address</c>.
        /// </summary>
        [JsonProperty("location_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location_source")]
#endif
        public string LocationSource { get; set; }
    }
}
