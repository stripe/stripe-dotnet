// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to <a href="https://docs.stripe.com/tax">calculate tax
        /// automatically</a> using the customer's location.
        ///
        /// Enabling this parameter causes Checkout to collect any billing address information
        /// necessary for tax calculation.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("liability")]
#endif
        public SessionAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
