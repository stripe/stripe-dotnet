namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderIndividual : StripeEntity<CardholderIndividual>
    {
        [JsonProperty("dob")]
        public CardholderIndividualDob Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("verification")]
        public CardholderIndividualVerification Verification { get; set; }
    }
}
