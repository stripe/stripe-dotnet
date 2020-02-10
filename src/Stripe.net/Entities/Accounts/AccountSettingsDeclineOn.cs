namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountSettingsDeclineOn : StripeEntity<AccountSettingsDeclineOn>
    {
        [JsonProperty("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}
