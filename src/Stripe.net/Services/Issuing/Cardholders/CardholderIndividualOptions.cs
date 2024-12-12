// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardholderIndividualOptions : INestedOptions
    {
        /// <summary>
        /// Information related to the card_issuing program for this cardholder.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public CardholderIndividualCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// The date of birth of this cardholder. Cardholders must be older than 13 years old.
        /// </summary>
        [JsonProperty("dob")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dob")]
#endif
        public CardholderIndividualDobOptions Dob { get; set; }

        /// <summary>
        /// The first name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
        /// </summary>
        [JsonProperty("first_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("first_name")]
#endif
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of this cardholder. Required before activating Cards. This field cannot
        /// contain any numbers, special characters (except periods, commas, hyphens, spaces and
        /// apostrophes) or non-latin letters.
        /// </summary>
        [JsonProperty("last_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_name")]
#endif
        public string LastName { get; set; }

        /// <summary>
        /// Government-issued ID document for this cardholder.
        /// </summary>
        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif
        public CardholderIndividualVerificationOptions Verification { get; set; }
    }
}
