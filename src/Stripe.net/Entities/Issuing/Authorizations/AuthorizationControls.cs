namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AuthorizationControls : StripeEntity<AuthorizationControls>
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("max_amount")]
        public long? MaxAmount { get; set; }

        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }
    }
}
