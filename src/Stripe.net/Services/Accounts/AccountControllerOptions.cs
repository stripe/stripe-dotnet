// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerOptions : INestedOptions
    {
        /// <summary>
        /// A hash of configuration describing the Connect application that controls the account.
        /// </summary>
        [JsonProperty("application")]
        public AccountControllerApplicationOptions Application { get; set; }

        /// <summary>
        /// Properties of the account's dashboard.
        /// </summary>
        [JsonProperty("dashboard")]
        public AccountControllerDashboardOptions Dashboard { get; set; }

        /// <summary>
        /// A hash of configuration for who pays Stripe fees for product usage on this account.
        /// </summary>
        [JsonProperty("fees")]
        public AccountControllerFeesOptions Fees { get; set; }

        /// <summary>
        /// A hash of configuration for products that have negative balance liability, and whether
        /// Stripe or a Connect application is responsible for them.
        /// </summary>
        [JsonProperty("losses")]
        public AccountControllerLossesOptions Losses { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting updated information when requirements
        /// on the account are due or change. Defaults to <c>stripe</c>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirement_collection")]
        public string RequirementCollection { get; set; }

        /// <summary>
        /// A hash of configuration for Stripe-hosted dashboards.
        /// </summary>
        [JsonProperty("stripe_dashboard")]
        public AccountControllerStripeDashboardOptions StripeDashboard { get; set; }
    }
}
