// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePhaseAutomaticTax : StripeEntity<SubscriptionSchedulePhaseAutomaticTax>
    {
        /// <summary>
        /// If Stripe disabled automatic tax, this enum describes why.
        /// </summary>
        [JsonProperty("disabled_reason")]
        [STJS.JsonPropertyName("disabled_reason")]
        public string DisabledReason { get; set; }

        /// <summary>
        /// Whether Stripe automatically computes tax on invoices created during this phase.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
        [STJS.JsonPropertyName("liability")]
        public SubscriptionSchedulePhaseAutomaticTaxLiability Liability { get; set; }
    }
}
