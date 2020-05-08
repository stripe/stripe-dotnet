namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirementsError : StripeEntity<AccountRequirementsError>
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("requirement")]
        public string Requirement { get; set; }
    }
}
