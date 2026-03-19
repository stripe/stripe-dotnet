// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCustomerAutomaticIndirectTax : StripeEntity<AccountConfigurationCustomerAutomaticIndirectTax>
    {
        /// <summary>
        /// The customer account's tax exemption status: <c>none</c>, <c>exempt</c>, or
        /// <c>reverse</c>. When <c>reverse</c>, invoice and receipt PDFs include "Reverse charge".
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("exempt")]
        [STJS.JsonPropertyName("exempt")]
        public string Exempt { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
        [STJS.JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The customer account's identified tax location, derived from <c>location_source</c>.
        /// Only rendered if the <c>automatic_indirect_tax</c> feature is requested and
        /// <c>active</c>.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public AccountConfigurationCustomerAutomaticIndirectTaxLocation Location { get; set; }

        /// <summary>
        /// Data source used to identify the customer account's tax location. Defaults to
        /// <c>identity_address</c>. Used for automatic indirect tax calculation.
        /// One of: <c>identity_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_address</c>.
        /// </summary>
        [JsonProperty("location_source")]
        [STJS.JsonPropertyName("location_source")]
        public string LocationSource { get; set; }
    }
}
