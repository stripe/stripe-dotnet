namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    // TODO: Rename to CardAuthorizationControls in a future major version and move to Card folder.
    public class AuthorizationControlsOptions : INestedOptions
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardAuthorizationControlsSpendingLimitOptions> SpendingLimits { get; set; }
    }
}
