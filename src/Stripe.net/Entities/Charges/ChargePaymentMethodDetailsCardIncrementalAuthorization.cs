// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardIncrementalAuthorization : StripeEntity<ChargePaymentMethodDetailsCardIncrementalAuthorization>
    {
        /// <summary>
        /// Indicates whether or not the incremental authorization feature is supported.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
