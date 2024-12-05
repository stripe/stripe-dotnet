// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionAutomaticTax : StripeEntity<SubscriptionAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this subscription.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        public SubscriptionAutomaticTaxLiability Liability { get; set; }
    }
}
