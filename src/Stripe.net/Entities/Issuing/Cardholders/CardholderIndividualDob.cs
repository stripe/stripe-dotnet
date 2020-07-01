namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualDob : StripeEntity<CardholderIndividualDob>
    {
        /// <summary>
        /// The day of birth, between 1 and 31.
        /// </summary>
        [JsonProperty("day")]
        public long? Day { get; set; }

        /// <summary>
        /// The month of birth, between 1 and 12.
        /// </summary>
        [JsonProperty("month")]
        public long? Month { get; set; }

        /// <summary>
        /// The four-digit year of birth.
        /// </summary>
        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
