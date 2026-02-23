// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentManagedPayments : StripeEntity<PaymentIntentManagedPayments>
    {
        /// <summary>
        /// Set to <c>true</c> to enable <a
        /// href="https://docs.stripe.com/payments/managed-payments">Managed Payments</a>, Stripe's
        /// merchant of record solution, for this session.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }
    }
}
