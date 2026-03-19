// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceSettingsDataCollectionEmailDelivery : StripeEntity<CadenceSettingsDataCollectionEmailDelivery>
    {
        /// <summary>
        /// Controls emails for when the payment is due. For example after the invoice is finalized
        /// and transitions to Open state.
        /// </summary>
        [JsonProperty("payment_due")]
        [STJS.JsonPropertyName("payment_due")]
        public CadenceSettingsDataCollectionEmailDeliveryPaymentDue PaymentDue { get; set; }
    }
}
