// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccount : StripeEntity<ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccount>
    {
        /// <summary>
        /// Bank name.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The routing number for the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
