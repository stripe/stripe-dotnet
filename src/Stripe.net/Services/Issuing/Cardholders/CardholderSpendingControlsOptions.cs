namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSpendingControlsOptions : INestedOptions
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardholderSpendingControlsSpendingLimitOptions> SpendingLimits { get; set; }

        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
