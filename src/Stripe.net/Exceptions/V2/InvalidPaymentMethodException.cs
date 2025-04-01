// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    using System.Net;
    using Newtonsoft.Json.Linq;

    public class InvalidPaymentMethodException : StripeException
    {
        private InvalidPaymentMethodException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message,
            string invalidParam)
            : base(httpStatusCode, stripeError)
        {
            this.InvalidParam = invalidParam;
        }

        /// <summary>
        /// One of: <c>account_number</c>, <c>fedwire_routing_number</c>, or <c>routing_number</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invalid_param")]
#endif
        public string InvalidParam { get; set; }

        internal static InvalidPaymentMethodException Parse(
            HttpStatusCode httpStatusCode,
            JToken body)
        {
            var stripeError = InvalidPaymentMethodError.FromJson<InvalidPaymentMethodError>(body);
            return new InvalidPaymentMethodException(httpStatusCode, stripeError, stripeError.Message, stripeError.InvalidParam);
        }
    }
}