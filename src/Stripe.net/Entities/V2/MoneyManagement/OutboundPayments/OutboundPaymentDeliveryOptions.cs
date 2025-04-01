// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentDeliveryOptions : StripeEntity<OutboundPaymentDeliveryOptions>
    {
        /// <summary>
        /// Open Enum. Method for bank account.
        /// One of: <c>automatic</c>, <c>local</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account")]
#endif
        public string BankAccount { get; set; }
    }
}
