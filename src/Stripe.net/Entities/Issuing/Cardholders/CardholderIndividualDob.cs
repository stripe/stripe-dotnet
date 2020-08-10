namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualDob : StripeEntity<CardholderIndividualDob>
    {
        [JsonProperty("day")]
        public long? Day { get; set; }

        [JsonProperty("month")]
        public long? Month { get; set; }

        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
