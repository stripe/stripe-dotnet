// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitDisputeBankTransfer : StripeEntity<DebitDisputeBankTransfer>
    {
        /// <summary>
        /// The bank network the dispute was originated on.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The reason for the dispute.
        /// One of: <c>incorrect_amount_or_date</c>, or <c>unauthorized</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The statement descriptor set by the originator of the debit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
