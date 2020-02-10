namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("default_settings")]
        public SubscriptionScheduleDefaultSettingsOptions DefaultSettings { get; set; }

        [JsonProperty("end_behavior")]
        public string EndBehavior { get; set; }

        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("phases")]
        public List<SubscriptionSchedulePhaseOptions> Phases { get; set; }

        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <summary>
        /// If the update changes the current phase, indicates if the changes should be prorated.
        /// Valid values are <c>create_prorations</c> or <c>none</c>, and the default value is
        /// <c>create_prorations</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }
    }
}
