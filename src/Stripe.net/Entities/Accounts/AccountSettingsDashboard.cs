namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsDashboard : StripeEntity<AccountSettingsDashboard>
    {
        /// <summary>
        /// The display name for this account. This is used on the Stripe Dashboard to
        /// differentiate between accounts.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The timezone used in the Stripe Dashboard for this account.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
