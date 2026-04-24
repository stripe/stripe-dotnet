// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class CannotProceedException : StripeException
    {
        private CannotProceedException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message,
            string reason)
            : base(httpStatusCode, stripeError)
        {
            this.Reason = reason;
        }

        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        internal static CannotProceedException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = CannotProceedError.FromJson<CannotProceedError>(body);
            return new CannotProceedException(httpStatusCode, stripeError, stripeError.Message, stripeError.Reason);
        }
    }
}