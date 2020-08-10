namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualVerification : StripeEntity<CardholderIndividualVerification>
    {
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocument Document { get; set; }
    }
}
