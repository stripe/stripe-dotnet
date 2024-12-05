// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodUsBankAccount : StripeEntity<PaymentMethodUsBankAccount>
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
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The ID of the Financial Connections Account used to create the payment method.
        /// </summary>
        [JsonProperty("financial_connections_account")]
        public string FinancialConnectionsAccount { get; set; }

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
        /// Contains information about US bank account networks that can be used.
        /// </summary>
        [JsonProperty("networks")]
        public PaymentMethodUsBankAccountNetworks Networks { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Contains information about the future reusability of this PaymentMethod.
        /// </summary>
        [JsonProperty("status_details")]
        public PaymentMethodUsBankAccountStatusDetails StatusDetails { get; set; }
    }
}
