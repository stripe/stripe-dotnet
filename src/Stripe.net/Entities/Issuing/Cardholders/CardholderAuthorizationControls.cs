namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderAuthorizationControls : StripeEntity<CardholderAuthorizationControls>
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardholderAuthorizationControlsSpendingLimit> SpendingLimits { get; set; }

        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
