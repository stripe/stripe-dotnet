// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsAutomaticPaymentMethods : StripeEntity<OrderPaymentSettingsAutomaticPaymentMethods>
    {
        /// <summary>
        /// Whether this Order has been opted into managing payment method types via the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
