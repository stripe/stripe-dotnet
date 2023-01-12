// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerDashboard : StripeEntity<AccountControllerDashboard>
    {
        /// <summary>
        /// Whether this account has access to the full Stripe dashboard (<c>full</c>), to the
        /// Express dashboard (<c>express</c>), or to no dashboard (<c>none</c>).
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
