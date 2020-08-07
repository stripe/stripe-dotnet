namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerification : StripeEntity<PersonVerification>
    {
        [JsonProperty("additional_document")]
        public PersonVerificationAdditionalDocument AdditionalDocument { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        [JsonProperty("document")]
        public PersonVerificationDocument Document { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
