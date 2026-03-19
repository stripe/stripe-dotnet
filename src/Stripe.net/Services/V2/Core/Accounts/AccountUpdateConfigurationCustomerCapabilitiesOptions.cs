// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCustomerCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// Generates requirements for enabling automatic indirect tax calculation on this
        /// customer's invoices or subscriptions. Recommended to request this capability if planning
        /// to enable automatic tax calculation on this customer's invoices or subscriptions.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
        [STJS.JsonPropertyName("automatic_indirect_tax")]
        public AccountUpdateConfigurationCustomerCapabilitiesAutomaticIndirectTaxOptions AutomaticIndirectTax { get; set; }
    }
}
