namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenAccountCompanyVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public TokenAccountCompanyVerificationDocumentOptions Document { get; set; }
    }
}
