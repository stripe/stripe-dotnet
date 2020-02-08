namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    // TODO: Rename to CardAuthorizationControls in a future major version and move to Card folder.
    public class AuthorizationControls : StripeEntity<AuthorizationControls>
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [Obsolete("Use Card.Currency instead.")]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete("Use SpendingLimits instead.")]
        [JsonProperty("max_amount")]
        public long? MaxAmount { get; set; }

        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardAuthorizationControlsSpendingLimit> SpendingLimits { get; set; }

        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
