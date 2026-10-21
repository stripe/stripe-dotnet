// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountActivityMfaRemoval : StripeEntity<AccountActivityMfaRemoval>
    {
        /// <summary>
        /// The authentication method removed from the account.
        /// One of: <c>authenticator_app</c>, <c>email</c>, <c>hardware_key</c>, <c>other</c>, or
        /// <c>sms</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("mfa_type")]
        [STJS.JsonPropertyName("mfa_type")]
        public string MfaType { get; set; }
    }
}
