// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Net;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class InvalidVaultedCredentialException : StripeException
    {
        private InvalidVaultedCredentialException(
            HttpStatusCode httpStatusCode,
            StripeError stripeError,
            string message,
            string invalidParam)
            : base(httpStatusCode, stripeError)
        {
            this.InvalidParam = invalidParam;
        }

        /// <summary>
        /// Closed Enum. The field that already exists on the resource.
        /// One of: <c>account_number</c>, <c>currency</c>, <c>iban</c>, or <c>sort_code</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
        [STJS.JsonPropertyName("invalid_param")]
        public string InvalidParam { get; set; }

        internal static InvalidVaultedCredentialException Parse(
            HttpStatusCode httpStatusCode,
            JsonElement body)
        {
            var stripeError = InvalidVaultedCredentialError.FromJson<InvalidVaultedCredentialError>(body);
            return new InvalidVaultedCredentialException(httpStatusCode, stripeError, stripeError.Message, stripeError.InvalidParam);
        }
    }
}