namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocumentOptions Document { get; set; }
    }
}
