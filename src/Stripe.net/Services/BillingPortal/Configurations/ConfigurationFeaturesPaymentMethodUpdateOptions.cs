// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConfigurationFeaturesPaymentMethodUpdateOptions : INestedOptions, IHasSetTracking
    {
        private string paymentMethodConfiguration;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/api/payment_method_configurations">Payment Method
        /// Configuration</a> to use for this portal session. When specified, customers will be able
        /// to update their payment method to one of the options specified by the payment method
        /// configuration. If not set or set to an empty string, the default payment method
        /// configuration is used.
        /// </summary>
        [JsonProperty("payment_method_configuration")]
        [STJS.JsonPropertyName("payment_method_configuration")]
        public string PaymentMethodConfiguration
        {
            get => this.paymentMethodConfiguration;
            set
            {
                this.paymentMethodConfiguration = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
