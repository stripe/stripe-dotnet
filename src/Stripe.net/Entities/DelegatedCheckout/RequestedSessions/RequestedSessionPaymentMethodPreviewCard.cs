// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodPreviewCard : StripeEntity<RequestedSessionPaymentMethodPreviewCard>
    {
        /// <summary>
        /// The expiry month of the card.
        /// </summary>
        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// The expiry year of the card.
        /// </summary>
        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }
    }
}
