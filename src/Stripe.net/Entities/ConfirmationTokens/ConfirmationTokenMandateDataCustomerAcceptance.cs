// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenMandateDataCustomerAcceptance : StripeEntity<ConfirmationTokenMandateDataCustomerAcceptance>
    {
        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonProperty("online")]
        [STJS.JsonPropertyName("online")]
        public ConfirmationTokenMandateDataCustomerAcceptanceOnline Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
