namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderAuthorizationControls : StripeEntity<CardholderAuthorizationControls>
    {
        /// <summary>
        /// Categories of authorizations permitted for this cardholder.
        /// </summary>
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Categories of authorizations to always decline for this cardholder.
        /// </summary>
        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

        /// <summary>
        /// Limit the spending with rules based on time intervals and categories.
        /// </summary>
        [JsonProperty("spending_limits")]
        public List<CardholderAuthorizationControlsSpendingLimit> SpendingLimits { get; set; }

        /// <summary>
        /// Currency for the amounts within <see cref="SpendingLimits"/>.
        /// </summary>
        [JsonProperty("spending_limits_currency")]
        public string SpendingLimitsCurrency { get; set; }
    }
}
