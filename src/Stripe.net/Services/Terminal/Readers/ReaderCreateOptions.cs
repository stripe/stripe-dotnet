namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderCreateOptions : ReaderSharedOptions
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("registration_code")]
        public string RegistrationCode { get; set; }
    }
}
