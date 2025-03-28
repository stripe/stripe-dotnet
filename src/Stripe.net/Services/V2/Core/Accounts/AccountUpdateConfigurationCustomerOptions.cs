// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCustomerOptions : INestedOptions
    {
        /// <summary>
        /// Automatic indirect tax settings to be used when automatic tax calculation is enabled on
        /// the customer's invoices, subscriptions, checkout sessions, or payment links. Surfaces if
        /// automatic tax calculation is possible given the current customer location information.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_indirect_tax")]
#endif
        public AccountUpdateConfigurationCustomerAutomaticIndirectTaxOptions AutomaticIndirectTax { get; set; }

        /// <summary>
        /// Billing settings - default settings used for this customer in Billing flows such as
        /// Invoices and Subscriptions.
        /// </summary>
        [JsonProperty("billing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing")]
#endif
        public AccountUpdateConfigurationCustomerBillingOptions Billing { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Customer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountUpdateConfigurationCustomerCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public AccountUpdateConfigurationCustomerShippingOptions Shipping { get; set; }

        /// <summary>
        /// ID of the test clock to attach to the customer. Can only be set on testmode Accounts,
        /// and when the Customer Configuration is first set on an Account.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }
    }
}
