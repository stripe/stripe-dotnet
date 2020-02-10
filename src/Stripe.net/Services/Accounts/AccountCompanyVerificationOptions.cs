namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountCompanyVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public AccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
