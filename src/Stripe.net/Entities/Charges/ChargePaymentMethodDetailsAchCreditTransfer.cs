namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAchCreditTransfer : StripeEntity<ChargePaymentMethodDetailsAchCreditTransfer>
    {
        /// <summary>
        /// Account number to transfer funds to.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Name of the bank associated with the routing number.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Routing transit number for the bank account to transfer funds to.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// SWIFT code of the bank associated with the routing number.
        /// </summary>
        [JsonProperty("swift_code")]
        public string SwiftCode { get; set; }
    }
}
