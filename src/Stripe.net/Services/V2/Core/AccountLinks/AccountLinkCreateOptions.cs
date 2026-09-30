// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountLinkCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Account to create link for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Specifies the Stripe-hosted flow for this Account Link. Set <c>type</c> and the matching
        /// options hash—for example, <c>account_onboarding</c>—to configure the flow, including
        /// which Account configurations to collect information for and any flow-specific collection
        /// or redirect options.
        /// </summary>
        [JsonProperty("use_case")]
        [STJS.JsonPropertyName("use_case")]
        public AccountLinkCreateUseCaseOptions UseCase { get; set; }
    }
}
