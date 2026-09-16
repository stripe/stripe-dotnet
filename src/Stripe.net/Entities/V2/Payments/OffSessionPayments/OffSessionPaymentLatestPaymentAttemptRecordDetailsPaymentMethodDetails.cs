// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetails : StripeEntity<OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetails>
    {
        /// <summary>
        /// Details about the card used for the latest payment attempt.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetailsCard Card { get; set; }
    }
}
