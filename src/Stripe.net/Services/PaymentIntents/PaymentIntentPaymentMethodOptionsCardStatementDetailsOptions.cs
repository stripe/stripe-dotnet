// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCardStatementDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Please pass in an address that is within your Stripe user account country.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Phone number (e.g., a toll-free number that customers can call).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
