// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordPaymentMethodDetailsCardOptions : INestedOptions
    {
        /// <summary>
        /// Verification checks performed on the card.
        /// </summary>
        [JsonProperty("checks")]
        [STJS.JsonPropertyName("checks")]
        public PaymentRecordPaymentMethodDetailsCardChecksOptions Checks { get; set; }
    }
}
