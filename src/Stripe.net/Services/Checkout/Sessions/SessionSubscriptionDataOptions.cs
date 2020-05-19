namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionSubscriptionDataOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("items")]
        public List<SessionSubscriptionDataItemOptions> Items { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty("trial_from_plan")]
        public bool? TrialFromPlan { get; set; }

        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}
