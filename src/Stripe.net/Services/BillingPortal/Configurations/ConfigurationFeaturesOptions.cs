// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Information about updating the customer details in the portal.
        /// </summary>
        [JsonProperty("customer_update")]
        public ConfigurationFeaturesCustomerUpdateOptions CustomerUpdate { get; set; }

        /// <summary>
        /// Information about showing the billing history in the portal.
        /// </summary>
        [JsonProperty("invoice_history")]
        public ConfigurationFeaturesInvoiceHistoryOptions InvoiceHistory { get; set; }

        /// <summary>
        /// Information about updating payment methods in the portal.
        /// </summary>
        [JsonProperty("payment_method_update")]
        public ConfigurationFeaturesPaymentMethodUpdateOptions PaymentMethodUpdate { get; set; }

        /// <summary>
        /// Information about canceling subscriptions in the portal.
        /// </summary>
        [JsonProperty("subscription_cancel")]
        public ConfigurationFeaturesSubscriptionCancelOptions SubscriptionCancel { get; set; }

        /// <summary>
        /// Information about updating subscriptions in the portal.
        /// </summary>
        [JsonProperty("subscription_update")]
        public ConfigurationFeaturesSubscriptionUpdateOptions SubscriptionUpdate { get; set; }
    }
}
