namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardSpendingControlsOptions : INestedOptions
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardSpendingControlsSpendingLimitOptions> SpendingLimits { get; set; }

        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
