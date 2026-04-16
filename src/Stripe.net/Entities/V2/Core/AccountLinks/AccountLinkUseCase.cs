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
        /// Open Enum. The type of Account Link the user is requesting.
        /// One of: <c>account_onboarding</c>, or <c>account_update</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
