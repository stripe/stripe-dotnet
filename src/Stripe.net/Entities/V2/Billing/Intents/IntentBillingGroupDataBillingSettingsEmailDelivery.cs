// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentBillingGroupDataBillingSettingsEmailDelivery : StripeEntity<IntentBillingGroupDataBillingSettingsEmailDelivery>
    {
        /// <summary>
        /// Controls emails for when the payment is due.
        /// </summary>
        [JsonProperty("payment_due")]
        [STJS.JsonPropertyName("payment_due")]
        public IntentBillingGroupDataBillingSettingsEmailDeliveryPaymentDue PaymentDue { get; set; }
    }
}
