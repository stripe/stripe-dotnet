// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeatures : StripeEntity<ConfigurationFeatures>
    {
        [JsonProperty("customer_update")]
        public ConfigurationFeaturesCustomerUpdate CustomerUpdate { get; set; }

        [JsonProperty("invoice_history")]
        public ConfigurationFeaturesInvoiceHistory InvoiceHistory { get; set; }

        [JsonProperty("payment_method_update")]
        public ConfigurationFeaturesPaymentMethodUpdate PaymentMethodUpdate { get; set; }

        [JsonProperty("subscription_cancel")]
        public ConfigurationFeaturesSubscriptionCancel SubscriptionCancel { get; set; }

        [JsonProperty("subscription_update")]
        public ConfigurationFeaturesSubscriptionUpdate SubscriptionUpdate { get; set; }
    }
}
