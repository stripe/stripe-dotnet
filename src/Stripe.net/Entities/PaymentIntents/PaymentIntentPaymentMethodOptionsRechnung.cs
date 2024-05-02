// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsRechnung : StripeEntity<PaymentIntentPaymentMethodOptionsRechnung>
    {
        /// <summary>
        /// A unique identifier that correlates each transaction with the collected risk data.
        /// </summary>
        [JsonProperty("risk_correlation_id")]
        public string RiskCorrelationId { get; set; }
    }
}
