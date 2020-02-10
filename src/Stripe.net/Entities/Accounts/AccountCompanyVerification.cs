namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        [JsonProperty("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
