// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCustomerOptions : INestedOptions
    {
        /// <summary>
        /// Represents the state of the configuration, and can be updated to deactivate or re-apply
        /// a configuration.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool? Applied { get; set; }

        /// <summary>
        /// Automatic indirect tax settings to be used when automatic tax calculation is enabled on
        /// the customer's invoices, subscriptions, checkout sessions, or payment links. Surfaces if
        /// automatic tax calculation is possible given the current customer location information.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
        [STJS.JsonPropertyName("automatic_indirect_tax")]
        public AccountUpdateConfigurationCustomerAutomaticIndirectTaxOptions AutomaticIndirectTax { get; set; }

        /// <summary>
        /// Billing settings - default settings used for this customer in Billing flows such as
        /// Invoices and Subscriptions.
        /// </summary>
        [JsonProperty("billing")]
        [STJS.JsonPropertyName("billing")]
        public AccountUpdateConfigurationCustomerBillingOptions Billing { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Customer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountUpdateConfigurationCustomerCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public AccountUpdateConfigurationCustomerShippingOptions Shipping { get; set; }

        /// <summary>
        /// ID of the test clock to attach to the customer. Can only be set on testmode Accounts,
        /// and when the Customer Configuration is first set on an Account.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
