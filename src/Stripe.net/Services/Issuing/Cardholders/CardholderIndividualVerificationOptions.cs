namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationOptions : INestedOptions
    {
        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocumentOptions Document { get; set; }
    }
}
