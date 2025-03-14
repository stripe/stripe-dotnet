// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewSubscriptionScheduleDefaultSettingsAutomaticTax : StripeEntity<QuotePreviewSubscriptionScheduleDefaultSettingsAutomaticTax>
    {
        /// <summary>
        /// If Stripe disabled automatic tax, this enum describes why.
        /// </summary>
        [JsonProperty("disabled_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Whether Stripe automatically computes tax on invoices created during this phase.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("liability")]
#endif
        public QuotePreviewSubscriptionScheduleDefaultSettingsAutomaticTaxLiability Liability { get; set; }
    }
}
