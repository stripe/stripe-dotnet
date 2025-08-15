// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDataAccountLinkCompletedEventData : StripeEntity<AccountConfigurationRecipientDataAccountLinkCompletedEventData>
    {
        /// <summary>
        /// Closed Enum. The use case type of the account link that has been completed.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("use_case")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("use_case")]
#endif
        public string UseCase { get; set; }
    }
}
