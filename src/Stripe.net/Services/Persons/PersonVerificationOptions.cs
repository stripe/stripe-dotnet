namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonVerificationOptions : INestedOptions
    {
        [JsonProperty("additional_document")]
        public PersonVerificationDocumentOptions AdditionalDocument { get; set; }

        [JsonProperty("document")]
        public PersonVerificationDocumentOptions Document { get; set; }
    }
}
