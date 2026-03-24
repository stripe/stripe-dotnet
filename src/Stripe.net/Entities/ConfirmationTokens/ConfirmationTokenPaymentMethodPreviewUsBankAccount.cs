// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfirmationTokenPaymentMethodPreviewUsBankAccount : StripeEntity<ConfirmationTokenPaymentMethodPreviewUsBankAccount>
    {
        /// <summary>
        /// Account holder type: individual or company.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        [STJS.JsonPropertyName("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Account number of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account type: checkings or savings. Defaults to checking if omitted.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
        [STJS.JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// The ID of the Financial Connections Account used to create the payment method.
        /// </summary>
        [JsonProperty("financial_connections_account")]
        [STJS.JsonPropertyName("financial_connections_account")]
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Contains information about US bank account networks that can be used.
        /// </summary>
        [JsonProperty("networks")]
        [STJS.JsonPropertyName("networks")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccountNetworks Networks { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Contains information about the future reusability of this PaymentMethod.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetails StatusDetails { get; set; }
    }
}
