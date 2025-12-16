// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountDefaultsResponsibilities : StripeEntity<AccountDefaultsResponsibilities>
    {
        /// <summary>
        /// Indicates whether the platform or connected account is responsible for paying Stripe
        /// fees for pricing-control-eligible products.
        /// One of: <c>application</c>, <c>application_custom</c>, <c>application_express</c>, or
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("fees_collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fees_collector")]
#endif
        public string FeesCollector { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("losses_collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("losses_collector")]
#endif
        public string LossesCollector { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("requirements_collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requirements_collector")]
#endif
        public string RequirementsCollector { get; set; }
    }
}
