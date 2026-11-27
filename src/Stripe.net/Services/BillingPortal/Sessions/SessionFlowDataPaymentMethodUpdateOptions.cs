// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionFlowDataPaymentMethodUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the subscription whose payment method the customer will update. The new
        /// payment method is set as the subscription's <c>default_payment_method</c> instead of the
        /// customer's <c>invoice_settings.default_payment_method</c>. Only supported in the
        /// redesigned customer portal.
        /// </summary>
        [JsonProperty("subscription")]
        [STJS.JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
