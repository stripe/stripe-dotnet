namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualVerificationDocumentOptions : INestedOptions
    {
        [JsonProperty("back")]
        public string Back { get; set; }

        [JsonProperty("front")]
        public string Front { get; set; }
    }
}
