// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCustomer : StripeEntity<AccountConfigurationCustomer>
    {
        /// <summary>
        /// Indicates whether the customer configuration is active. You can deactivate or reactivate
        /// the customer configuration by updating this property. Deactivating the configuration by
        /// setting this value to false will unrequest all capabilities within the configuration. It
        /// will not delete any of the configuration's other properties.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Settings for automatic indirect tax calculation on the customer's invoices,
        /// subscriptions, Checkout Sessions, and Payment Links. Available when automatic tax
        /// calculation is available for the customer account's location.
        /// </summary>
        [JsonProperty("automatic_indirect_tax")]
        [STJS.JsonPropertyName("automatic_indirect_tax")]
        public AccountConfigurationCustomerAutomaticIndirectTax AutomaticIndirectTax { get; set; }

        /// <summary>
        /// Default Billing settings for the customer account, used in Invoices and Subscriptions.
        /// </summary>
        [JsonProperty("billing")]
        [STJS.JsonPropertyName("billing")]
        public AccountConfigurationCustomerBilling Billing { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Customer Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationCustomerCapabilities Capabilities { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public AccountConfigurationCustomerShipping Shipping { get; set; }

        /// <summary>
        /// ID of the test clock to attach to the customer. Can only be set on testmode Accounts,
        /// and when the Customer Configuration is first set on an Account.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
