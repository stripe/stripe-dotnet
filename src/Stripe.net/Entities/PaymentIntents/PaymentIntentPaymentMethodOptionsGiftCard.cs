// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsGiftCard : StripeEntity<PaymentIntentPaymentMethodOptionsGiftCard>
    {
        /// <summary>
        /// Set to <c>yes</c> to ignore the application fee on the PaymentIntent when redeeming this
        /// gift card.
        /// </summary>
        [JsonProperty("ignore_application_fee")]
        [STJS.JsonPropertyName("ignore_application_fee")]
        public string IgnoreApplicationFee { get; set; }

        /// <summary>
        /// Set to <c>yes</c> to ignore transfer data on the PaymentIntent when redeeming this gift
        /// card.
        /// </summary>
        [JsonProperty("ignore_transfer_data")]
        [STJS.JsonPropertyName("ignore_transfer_data")]
        public string IgnoreTransferData { get; set; }

        /// <summary>
        /// Request partial authorization on this PaymentIntent.
        /// One of: <c>if_available</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("request_partial_authorization")]
        [STJS.JsonPropertyName("request_partial_authorization")]
        public string RequestPartialAuthorization { get; set; }
    }
}
