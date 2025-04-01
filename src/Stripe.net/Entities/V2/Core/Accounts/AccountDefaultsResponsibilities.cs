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
        /// A value indicating the responsible payer of a bundle of Stripe fees for pricing-control
        /// eligible products on this Account.
        /// One of: <c>application</c>, or <c>stripe</c>.
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
