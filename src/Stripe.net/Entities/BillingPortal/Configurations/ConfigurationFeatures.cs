// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationFeatures : StripeEntity<ConfigurationFeatures>
    {
        [JsonProperty("customer_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_update")]
#endif

        public ConfigurationFeaturesCustomerUpdate CustomerUpdate { get; set; }

        [JsonProperty("invoice_history")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_history")]
#endif

        public ConfigurationFeaturesInvoiceHistory InvoiceHistory { get; set; }

        [JsonProperty("payment_method_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_update")]
#endif

        public ConfigurationFeaturesPaymentMethodUpdate PaymentMethodUpdate { get; set; }

        [JsonProperty("subscription_cancel")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_cancel")]
#endif

        public ConfigurationFeaturesSubscriptionCancel SubscriptionCancel { get; set; }

        [JsonProperty("subscription_update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_update")]
#endif

        public ConfigurationFeaturesSubscriptionUpdate SubscriptionUpdate { get; set; }
    }
}
