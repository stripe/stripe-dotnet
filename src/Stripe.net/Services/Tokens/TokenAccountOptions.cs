// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenAccountOptions : INestedOptions
    {
        /// <summary>
        /// The business type.
        /// One of: <c>company</c>, <c>government_entity</c>, <c>individual</c>, or
        /// <c>non_profit</c>.
        /// </summary>
        [JsonProperty("business_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_type")]
#endif

        public string BusinessType { get; set; }

        /// <summary>
        /// Information about the company or business.
        /// </summary>
        [JsonProperty("company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("company")]
#endif

        public TokenAccountCompanyOptions Company { get; set; }

        /// <summary>
        /// Information about the person represented by the account.
        /// </summary>
        [JsonProperty("individual")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("individual")]
#endif

        public TokenAccountIndividualOptions Individual { get; set; }

        /// <summary>
        /// Whether the user described by the data in the token has been shown <a
        /// href="https://stripe.com/connect/account-tokens#stripe-connected-account-agreement">the
        /// Stripe Connected Account Agreement</a>. When creating an account token to create a new
        /// Connect account, this value must be <c>true</c>.
        /// </summary>
        [JsonProperty("tos_shown_and_accepted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tos_shown_and_accepted")]
#endif

        public bool? TosShownAndAccepted { get; set; }
    }
}
