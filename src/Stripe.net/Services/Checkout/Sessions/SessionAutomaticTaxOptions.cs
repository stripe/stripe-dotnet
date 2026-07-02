// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAutomaticTaxOptions : INestedOptions
    {
        /// <summary>
        /// Controls how much address information Checkout collects when <a
        /// href="https://stripe.com/docs/api/checkout/sessions/object#checkout_session_object-automatic_tax-enabled">automatic_tax</a>
        /// is enabled.
        ///
        /// Defaults to <c>full</c>, which collects the address fields needed for the most accurate
        /// tax calculation. Set to <c>minimal</c> to collect only the fields required for tax in
        /// the buyer's country, accepting potentially less precise tax calculation in exchange for
        /// a streamlined form.
        ///
        /// Only honored when <c>automatic_tax.enabled</c> is <c>true</c>,
        /// <c>billing_address_collection</c> is <c>auto</c>, the resolved tax address source is the
        /// session billing address, and <c>ui_mode</c> is <c>form</c>.
        /// One of: <c>full</c>, or <c>minimal</c>.
        /// </summary>
        [JsonProperty("address_collection_precision")]
        [STJS.JsonPropertyName("address_collection_precision")]
        public string AddressCollectionPrecision { get; set; }

        /// <summary>
        /// Set to <c>true</c> to <a href="https://docs.stripe.com/tax">calculate tax
        /// automatically</a> using the customer's location.
        ///
        /// Enabling this parameter causes Checkout to collect any billing address information
        /// necessary for tax calculation.
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
        public SessionAutomaticTaxLiabilityOptions Liability { get; set; }
    }
}
