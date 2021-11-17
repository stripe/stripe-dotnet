// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAutomaticPaymentMethods : StripeEntity<PaymentIntentAutomaticPaymentMethods>
    {
        /// <summary>
        /// Automatically calculates compatible payment methods.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
