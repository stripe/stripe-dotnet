// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCustomerCapabilities : StripeEntity<AccountConfigurationCustomerCapabilities>
    {
        /// <summary>
        /// Generates requirements for enabling automatic indirect tax calculation on this
        /// customer's invoices or subscriptions. Recommended to request this capability if planning
        /// to enable automatic tax calculation on this customer's invoices or subscriptions. Uses
        /// the <c>location_source</c> field.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_indirect_tax")]
#endif
        public AccountConfigurationCustomerCapabilitiesAutomaticIndirectTax AutomaticIndirectTax { get; set; }
    }
}
