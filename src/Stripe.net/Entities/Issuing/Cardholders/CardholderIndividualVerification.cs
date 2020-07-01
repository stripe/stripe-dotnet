namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualVerification : StripeEntity<CardholderIndividualVerification>
    {
        /// <summary>
        /// An identifying document, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocument Document { get; set; }
    }
}
