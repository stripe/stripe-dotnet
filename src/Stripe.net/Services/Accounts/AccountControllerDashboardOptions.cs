// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerDashboardOptions : INestedOptions
    {
        /// <summary>
        /// Whether this account should have access to the full Stripe Dashboard (<c>full</c>), to
        /// the Express Dashboard (<c>express</c>), or to no Stripe-hosted dashboard (<c>none</c>).
        /// Defaults to <c>full</c>.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
