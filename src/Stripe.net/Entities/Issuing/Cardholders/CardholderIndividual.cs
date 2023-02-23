// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividual : StripeEntity<CardholderIndividual>
    {
        /// <summary>
        /// Information related to the card_issuing program for this cardholder.
        /// </summary>
        [JsonProperty("card_issuing")]
        public CardholderIndividualCardIssuing CardIssuing { get; set; }

        /// <summary>
        /// The date of birth of this cardholder.
        /// </summary>
        [JsonProperty("dob")]
        public CardholderIndividualDob Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
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
