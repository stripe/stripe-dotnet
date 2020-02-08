namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TokenPersonVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public TokenPersonVerificationDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public TokenPersonVerificationDocumentOptions Document { get; set; }
    }
}
