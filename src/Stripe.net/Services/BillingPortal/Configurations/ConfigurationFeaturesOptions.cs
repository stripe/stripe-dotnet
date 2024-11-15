// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Information about updating the customer details in the portal.
        /// </summary>
        [JsonProperty("customer_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_update")]
#endif

        public ConfigurationFeaturesCustomerUpdateOptions CustomerUpdate { get; set; }

        /// <summary>
        /// Information about showing the billing history in the portal.
        /// </summary>
        [JsonProperty("invoice_history")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_history")]
#endif

        public ConfigurationFeaturesInvoiceHistoryOptions InvoiceHistory { get; set; }

        /// <summary>
        /// Information about updating payment methods in the portal.
        /// </summary>
        [JsonProperty("payment_method_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_update")]
#endif

        public ConfigurationFeaturesPaymentMethodUpdateOptions PaymentMethodUpdate { get; set; }

        /// <summary>
        /// Information about canceling subscriptions in the portal.
        /// </summary>
        [JsonProperty("subscription_cancel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel")]
#endif

        public ConfigurationFeaturesSubscriptionCancelOptions SubscriptionCancel { get; set; }

        /// <summary>
        /// Information about updating subscriptions in the portal.
        /// </summary>
        [JsonProperty("subscription_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_update")]
#endif

        public ConfigurationFeaturesSubscriptionUpdateOptions SubscriptionUpdate { get; set; }
    }
}
