// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class InvalidPaymentMethodError : StripeError
    {
        /// <summary>
        /// One of: <c>account_number</c>, <c>currency</c>, <c>fedwire_routing_number</c>, or
        /// <c>routing_number</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
        [STJS.JsonPropertyName("invalid_param")]
        public string InvalidParam { get; set; }
    }
}