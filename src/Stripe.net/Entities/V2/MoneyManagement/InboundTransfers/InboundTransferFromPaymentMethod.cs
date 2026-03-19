// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferFromPaymentMethod : StripeEntity<InboundTransferFromPaymentMethod>
    {
        /// <summary>
        /// The type of object this destination represents. For a us bank account, we expect
        /// us_bank_account.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The destination US bank account identifier. eg "usba_***".
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public string UsBankAccount { get; set; }
    }
}
