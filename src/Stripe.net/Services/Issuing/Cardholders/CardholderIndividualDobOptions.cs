namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividualDobOptions : INestedOptions
    {
        [JsonProperty("day")]
        public long? Day { get; set; }

        [JsonProperty("month")]
        public long? Month { get; set; }

        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
