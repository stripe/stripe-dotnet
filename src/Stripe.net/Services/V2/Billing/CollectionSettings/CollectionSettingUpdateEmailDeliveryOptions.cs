// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CollectionSettingUpdateEmailDeliveryOptions : INestedOptions
    {
        /// <summary>
        /// Controls emails for when the payment is due. For example after the invoice is finalized
        /// and transitions to Open state.
        /// </summary>
        [JsonProperty("payment_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_due")]
#endif
        public CollectionSettingUpdateEmailDeliveryPaymentDueOptions PaymentDue { get; set; }
    }
}
