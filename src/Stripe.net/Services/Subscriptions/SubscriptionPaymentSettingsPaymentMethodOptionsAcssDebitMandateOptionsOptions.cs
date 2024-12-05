// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }
    }
}
