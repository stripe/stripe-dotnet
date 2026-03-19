// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentMethodOptionsCardStatementDetails : StripeEntity<PaymentIntentPaymentMethodOptionsCardStatementDetails>
    {
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public PaymentIntentPaymentMethodOptionsCardStatementDetailsAddress Address { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
