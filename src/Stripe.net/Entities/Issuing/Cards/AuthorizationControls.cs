namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationControls : StripeEntity
    {
        /// <summary>
        /// Categories of authorizations permitted on this card.
        /// </summary>
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Categories of authorizations to always decline on this card.
        /// </summary>
        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        /// <summary>
        /// Limit the spending with rules based on time intervals and categories.
        /// </summary>
        [JsonProperty("spending_limits")]
        public List<SpendingLimit> SpendingLimits { get; set; }

        [Obsolete("This is now unsupported")]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete("Use SpendingLimits")]
        [JsonProperty("max_amount")]
        public long? MaxAmount { get; set; }

        [Obsolete("Use SpendingLimits")]
        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }
    }
}
