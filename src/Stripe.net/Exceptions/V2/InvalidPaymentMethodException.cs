// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    using System.Net;
    using System.Text.Json;
    public class InvalidPaymentMethodException : StripeException
    {
        private InvalidPaymentMethodException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message,
            string InvalidParam)
            : base(httpStatusCode, stripeError)
        {
            this.InvalidParam = InvalidParam;
        }

        /// <summary>
        /// One of: <c>account_number</c>, <c>currency</c>, <c>fedwire_routing_number</c>, or
        /// <c>routing_number</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
        [STJS.JsonPropertyName("invalid_param")]
        public string InvalidParam { get; set; }

        internal static InvalidPaymentMethodException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = InvalidPaymentMethodError.FromJson<InvalidPaymentMethodError>(body);
            return new InvalidPaymentMethodException(httpStatusCode, stripeError, stripeError.Message, stripeError.InvalidParam);
        }
    }
}