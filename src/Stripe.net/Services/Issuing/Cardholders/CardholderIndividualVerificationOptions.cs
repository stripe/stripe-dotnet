namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocumentOptions Document { get; set; }
    }
}
