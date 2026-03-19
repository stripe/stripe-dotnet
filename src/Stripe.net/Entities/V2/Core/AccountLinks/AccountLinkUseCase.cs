// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountLinkUseCase : StripeEntity<AccountLinkUseCase>
    {
        /// <summary>
        /// Open Enum. The type of Account Link the user is requesting.
        /// One of: <c>account_onboarding</c>, <c>account_update</c>, <c>recipient_onboarding</c>,
        /// or <c>recipient_update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link object that onboards a new
        /// account.
        /// </summary>
        [JsonProperty("account_onboarding")]
        [STJS.JsonPropertyName("account_onboarding")]
        public AccountLinkUseCaseAccountOnboarding AccountOnboarding { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link that updates an existing
        /// account.
        /// </summary>
        [JsonProperty("account_update")]
        [STJS.JsonPropertyName("account_update")]
        public AccountLinkUseCaseAccountUpdate AccountUpdate { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link object that onboards a new
        /// recipient.
        /// </summary>
        [JsonProperty("recipient_onboarding")]
        [STJS.JsonPropertyName("recipient_onboarding")]
        public AccountLinkUseCaseRecipientOnboarding RecipientOnboarding { get; set; }

        /// <summary>
        /// Hash containing configuration options for an Account Link that updates an existing
        /// recipient.
        /// </summary>
        [JsonProperty("recipient_update")]
        [STJS.JsonPropertyName("recipient_update")]
        public AccountLinkUseCaseRecipientUpdate RecipientUpdate { get; set; }
    }
}
