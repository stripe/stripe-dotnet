namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationOptions : INestedOptions
    {
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocumentOptions Document { get; set; }
    }
}
