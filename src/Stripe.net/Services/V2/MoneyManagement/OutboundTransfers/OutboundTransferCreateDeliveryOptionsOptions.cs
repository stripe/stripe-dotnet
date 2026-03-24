// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferCreateDeliveryOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Open Enum. Method for bank account.
        /// One of: <c>automatic</c>, <c>local</c>, or <c>wire</c>.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }
    }
}
