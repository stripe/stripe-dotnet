// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to <a href="https://docs.stripe.com/tax">calculate tax
        /// automatically</a> using the customer's location.
        ///
        /// Enabling this parameter causes the payment link to collect any billing address
        /// information necessary for tax calculation.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        [STJS.JsonPropertyName("liability")]
        public PaymentLinkAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
