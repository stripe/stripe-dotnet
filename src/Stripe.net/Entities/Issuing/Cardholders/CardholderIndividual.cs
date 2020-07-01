namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividual : StripeEntity<CardholderIndividual>
    {
        /// <summary>
        /// The date of birth of this cardholder.
        /// </summary>
        [JsonProperty("dob")]
        public CardholderIndividualDob Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Government-issued ID document for this cardholder.
        /// </summary>
        [JsonProperty("verification")]
        public CardholderIndividualVerification Verification { get; set; }
    }
}
