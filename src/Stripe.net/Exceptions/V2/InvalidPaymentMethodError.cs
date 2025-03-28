// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvalidPaymentMethodError : StripeError
    {
        /// <summary>
        /// One of: <c>account_number</c>, <c>fedwire_routing_number</c>, or <c>routing_number</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invalid_param")]
#endif
        public string InvalidParam { get; set; }
    }
}