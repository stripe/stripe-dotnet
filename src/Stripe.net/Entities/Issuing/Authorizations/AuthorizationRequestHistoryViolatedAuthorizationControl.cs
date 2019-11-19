namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AuthorizationRequestHistoryViolatedAuthorizationControl : StripeEntity<AuthorizationRequestHistoryViolatedAuthorizationControl>
    {
        /// <summary>
        /// Entity which the authorization control acts on. One of <c>account</c>, <c>card</c>, or
        /// <c>cardholder</c>.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Name of the authorization control. One of <c>allowed_categories</c>,
        /// <c>blocked_categories</c>, <c>max_amount</c>, <c>max_approvals</c>, or
        /// <c>spending_limits</c>.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
