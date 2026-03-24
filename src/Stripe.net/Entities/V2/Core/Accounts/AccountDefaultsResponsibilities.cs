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
        /// Indicates whether the platform or connected account is responsible for paying Stripe
        /// fees for pricing-control-eligible products.
        /// One of: <c>application</c>, <c>application_custom</c>, <c>application_express</c>, or
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("fees_collector")]
        [STJS.JsonPropertyName("fees_collector")]
        public string FeesCollector { get; set; }

        /// <summary>
        /// A value indicating responsibility for collecting requirements on this account.
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
