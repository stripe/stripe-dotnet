namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerification : StripeEntity<AccountCompanyVerification>
    {
        /// <summary>
        /// A document for the company.
        /// </summary>
        [JsonProperty("document")]
        public AccountCompanyVerificationDocument Document { get; set; }
    }
}
