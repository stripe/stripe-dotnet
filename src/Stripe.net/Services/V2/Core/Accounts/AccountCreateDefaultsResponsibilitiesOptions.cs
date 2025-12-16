// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateDefaultsResponsibilitiesOptions : INestedOptions
    {
        /// <summary>
        /// A value indicating the party responsible for collecting fees from this account.
        /// One of: <c>application</c>, <c>application_custom</c>, <c>application_express</c>, or
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("fees_collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fees_collector")]
#endif
        public string FeesCollector { get; set; }

        /// <summary>
        /// A value indicating who is responsible for losses when this Account can’t pay back
        /// negative balances from payments.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("losses_collector")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("losses_collector")]
#endif
        public string LossesCollector { get; set; }
    }
}
