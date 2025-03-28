// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferFromPaymentMethod : StripeEntity<InboundTransferFromPaymentMethod>
    {
        /// <summary>
        /// The type of object this destination represents. For a us bank account, we expect
        /// us_bank_account.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The destination US bank account identifier. eg "usba_***".
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public string UsBankAccount { get; set; }
    }
}
