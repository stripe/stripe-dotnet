// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateBillingGroupDataBillingSettingsEmailDeliveryOptions : INestedOptions
    {
        /// <summary>
        /// Controls emails for when the payment is due. Omit to use the applicable default.
        /// </summary>
        [JsonProperty("payment_due")]
        [STJS.JsonPropertyName("payment_due")]
        public IntentCreateBillingGroupDataBillingSettingsEmailDeliveryPaymentDueOptions PaymentDue { get; set; }
    }
}
