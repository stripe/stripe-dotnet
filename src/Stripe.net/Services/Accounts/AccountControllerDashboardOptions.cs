// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerDashboardOptions : INestedOptions
    {
        /// <summary>
        /// Whether this account should have access to the full Stripe dashboard (<c>full</c>) or no
        /// dashboard (<c>none</c>).
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
