// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class InvalidVaultedCredentialError : StripeError
    {
        /// <summary>
        /// Closed Enum. The field that already exists on the resource.
        /// One of: <c>account_number</c>, <c>currency</c>, <c>iban</c>, or <c>sort_code</c>.
        /// </summary>
        [JsonProperty("invalid_param")]
        [STJS.JsonPropertyName("invalid_param")]
        public string InvalidParam { get; set; }
    }
}