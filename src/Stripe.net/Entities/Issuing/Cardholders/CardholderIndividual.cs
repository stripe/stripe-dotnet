// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CardholderIndividual : StripeEntity<CardholderIndividual>
    {
        /// <summary>
        /// Information related to the card_issuing program for this cardholder.
        /// </summary>
        [JsonProperty("card_issuing")]
        [STJS.JsonPropertyName("card_issuing")]
        public CardholderIndividualCardIssuing CardIssuing { get; set; }

        /// <summary>
        /// The date of birth of this cardholder.
        /// </summary>
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public CardholderIndividualDob Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
        /// </summary>
        [JsonProperty("first_name")]
        [STJS.JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
        /// </summary>
        [JsonProperty("last_name")]
        [STJS.JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Government-issued ID document for this cardholder.
        /// </summary>
        [JsonProperty("verification")]
        [STJS.JsonPropertyName("verification")]
        public CardholderIndividualVerification Verification { get; set; }
    }
}
