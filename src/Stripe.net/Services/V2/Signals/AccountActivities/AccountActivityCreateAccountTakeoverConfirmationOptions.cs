// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateAccountTakeoverConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// The type of credential involved in the confirmed takeover.
        /// One of: <c>api_key</c>, <c>login_password</c>, or <c>other</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("credential_type")]
        [STJS.JsonPropertyName("credential_type")]
        public string CredentialType { get; set; }
    }
}
