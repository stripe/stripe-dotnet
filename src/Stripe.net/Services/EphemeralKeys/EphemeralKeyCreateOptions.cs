namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the Customer you'd like to modify using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of the Issuing Card you'd like to access using the resulting ephemeral key.
        /// </summary>
        [JsonProperty("issuing_card")]
        public string IssuingCard { get; set; }

        [JsonIgnore]
        public string StripeVersion { get; set; }
    }
}
