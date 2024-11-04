// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentRecordCustomerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The customer who made the payment.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
