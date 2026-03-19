// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputePaymentMethodDetailsKlarna : StripeEntity<DisputePaymentMethodDetailsKlarna>
    {
        /// <summary>
        /// Chargeback loss reason mapped by Stripe from Klarna's chargeback loss reason.
        /// </summary>
        [JsonProperty("chargeback_loss_reason_code")]
        [STJS.JsonPropertyName("chargeback_loss_reason_code")]
        public string ChargebackLossReasonCode { get; set; }

        /// <summary>
        /// The reason for the dispute as defined by Klarna.
        /// </summary>
        [JsonProperty("reason_code")]
        [STJS.JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }
    }
}
