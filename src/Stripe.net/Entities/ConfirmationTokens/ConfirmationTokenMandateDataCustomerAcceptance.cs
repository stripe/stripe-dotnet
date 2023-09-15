// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenMandateDataCustomerAcceptance : StripeEntity<ConfirmationTokenMandateDataCustomerAcceptance>
    {
        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonProperty("online")]
        public ConfirmationTokenMandateDataCustomerAcceptanceOnline Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
