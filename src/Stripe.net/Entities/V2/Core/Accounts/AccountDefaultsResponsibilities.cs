// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountDefaultsResponsibilities : StripeEntity<AccountDefaultsResponsibilities>
    {
        /// <summary>
        /// Controls who pays Stripe fees for direct charges and other pricing-control-eligible
        /// Stripe products. For new integrations, setting <c>losses_collector=application</c>
        /// requires <c>fees_collector=application</c>; legacy Custom and Express accounts can also
        /// use <c>application_custom</c> or <c>application_express</c>. For destination charges and
        /// separate charges and transfers, Stripe bills the platform regardless of this setting.
        /// Learn more about <a
        /// href="https://docs.stripe.com/connect/direct-charges-fee-payer-behavior">fee behavior on
        /// connected accounts</a>, including application fees and pricing considerations.
        /// One of: <c>application</c>, <c>application_custom</c>, <c>application_express</c>, or
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("fees_collector")]
        [STJS.JsonPropertyName("fees_collector")]
        public string FeesCollector { get; set; }

        /// <summary>
        /// Controls who is responsible for payment-related negative balances on this account. The
        /// platform remains liable for negative balances on its own account. To use Stripe negative
        /// balance liability, your integration must meet <a
        /// href="https://docs.stripe.com/connect/risk-management/managed-risk">Managed Risk
        /// requirements</a>.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("losses_collector")]
        [STJS.JsonPropertyName("losses_collector")]
        public string LossesCollector { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirements_collector")]
        [STJS.JsonPropertyName("requirements_collector")]
        public string RequirementsCollector { get; set; }
    }
}
