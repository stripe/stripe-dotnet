// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class InboundTransferOriginPaymentMethodDetailsUsBankAccount : StripeEntity<InboundTransferOriginPaymentMethodDetailsUsBankAccount>
    {
        /// <summary>
        /// Account holder type: individual or company.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Account type: checkings or savings. Defaults to checking if omitted.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The network rails used. See the <a
        /// href="https://stripe.com/docs/treasury/money-movement/timelines">docs</a> to learn more
        /// about money movement timelines for each network type.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
