// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenMandateData : StripeEntity<ConfirmationTokenMandateData>
    {
        /// <summary>
        /// This hash contains details about the customer acceptance of the Mandate.
        /// </summary>
        [JsonProperty("customer_acceptance")]
        [STJS.JsonPropertyName("customer_acceptance")]
        public ConfirmationTokenMandateDataCustomerAcceptance CustomerAcceptance { get; set; }
    }
}
