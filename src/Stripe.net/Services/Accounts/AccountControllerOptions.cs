// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerOptions : INestedOptions
    {
        /// <summary>
        /// A hash of configuration describing the Connect application that controls the account.
        /// </summary>
        [JsonProperty("application")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application")]
#endif
        public AccountControllerApplicationOptions Application { get; set; }

        /// <summary>
        /// Properties of the account's dashboard.
        /// </summary>
        [JsonProperty("dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dashboard")]
#endif
        public AccountControllerDashboardOptions Dashboard { get; set; }

        /// <summary>
        /// A hash of configuration for who pays Stripe fees for product usage on this account.
        /// </summary>
        [JsonProperty("fees")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fees")]
#endif
        public AccountControllerFeesOptions Fees { get; set; }

        /// <summary>
        /// A hash of configuration for products that have negative balance liability, and whether
        /// Stripe or a Connect application is responsible for them.
        /// </summary>
        [JsonProperty("losses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("losses")]
#endif
        public AccountControllerLossesOptions Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting updated information when requirements
        /// on the account are due or change. Defaults to <c>stripe</c>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirement_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirement_collection")]
#endif
        public string RequirementCollection { get; set; }

        /// <summary>
        /// A hash of configuration for Stripe-hosted dashboards.
        /// </summary>
        [JsonProperty("stripe_dashboard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_dashboard")]
#endif
        public AccountControllerStripeDashboardOptions StripeDashboard { get; set; }
    }
}
