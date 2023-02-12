// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerOptions : INestedOptions
    {
        /// <summary>
        /// The documentation for the application hash.
        /// </summary>
        [JsonProperty("application")]
        public AccountControllerApplicationOptions Application { get; set; }

        /// <summary>
        /// Properties of the account's dashboard.
        /// </summary>
        [JsonProperty("dashboard")]
        public AccountControllerDashboardOptions Dashboard { get; set; }
    }
}
