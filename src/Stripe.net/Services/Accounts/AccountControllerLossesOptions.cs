// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountControllerLossesOptions : INestedOptions
    {
        /// <summary>
        /// Controls who is responsible for payment-related negative balances on this account. The
        /// platform remains liable for negative balances on its own account. To use Stripe negative
        /// balance liability, your integration must meet <a
        /// href="https://docs.stripe.com/connect/risk-management/managed-risk">Managed Risk
        /// requirements</a>. Defaults to <c>stripe</c>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("payments")]
        [STJS.JsonPropertyName("payments")]
        public string Payments { get; set; }
    }
}
