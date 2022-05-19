// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The bank account holder's name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The bank account number.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The bank account's routing number.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
