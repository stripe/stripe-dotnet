// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenMandateData : StripeEntity<ConfirmationTokenMandateData>
    {
        /// <summary>
        /// This hash contains details about the customer acceptance of the Mandate.
        /// </summary>
        [JsonProperty("customer_acceptance")]
        public ConfirmationTokenMandateDataCustomerAcceptance CustomerAcceptance { get; set; }
    }
}
