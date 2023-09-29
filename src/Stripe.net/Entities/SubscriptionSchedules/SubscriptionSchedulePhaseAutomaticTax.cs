// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseAutomaticTax : StripeEntity<SubscriptionSchedulePhaseAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on invoices created during this phase.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        public SubscriptionSchedulePhaseAutomaticTaxLiability Liability { get; set; }
    }
}
