namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class AuthorizationControlsOptions : INestedOptions
    {
        [FormProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [FormProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        [FormProperty("max_amount")]
        public int? MaxAmount { get; set; }

        [FormProperty("max_approvals")]
        public int? MaxApprovals { get; set; }
    }
}
