// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeatures : StripeEntity<ConfigurationFeatures>
    {
        [JsonProperty("customer_update")]
        [STJS.JsonPropertyName("customer_update")]
        public ConfigurationFeaturesCustomerUpdate CustomerUpdate { get; set; }

        [JsonProperty("invoice_history")]
        [STJS.JsonPropertyName("invoice_history")]
        public ConfigurationFeaturesInvoiceHistory InvoiceHistory { get; set; }

        [JsonProperty("payment_method_update")]
        [STJS.JsonPropertyName("payment_method_update")]
        public ConfigurationFeaturesPaymentMethodUpdate PaymentMethodUpdate { get; set; }

        [JsonProperty("subscription_cancel")]
        [STJS.JsonPropertyName("subscription_cancel")]
        public ConfigurationFeaturesSubscriptionCancel SubscriptionCancel { get; set; }

        [JsonProperty("subscription_update")]
        [STJS.JsonPropertyName("subscription_update")]
        public ConfigurationFeaturesSubscriptionUpdate SubscriptionUpdate { get; set; }
    }
}
