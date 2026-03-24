// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CollectionSettingUpdateEmailDeliveryOptions : INestedOptions
    {
        /// <summary>
        /// Controls emails for when the payment is due. For example after the invoice is finalized
        /// and transitions to Open state.
        /// </summary>
        [JsonProperty("payment_due")]
        [STJS.JsonPropertyName("payment_due")]
        public CollectionSettingUpdateEmailDeliveryPaymentDueOptions PaymentDue { get; set; }
    }
}
