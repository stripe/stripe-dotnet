// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsMobilepay : StripeEntity<PaymentRecordPaymentMethodDetailsMobilepay>
    {
        /// <summary>
        /// Internal card details.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public PaymentRecordPaymentMethodDetailsMobilepayCard Card { get; set; }
    }
}
