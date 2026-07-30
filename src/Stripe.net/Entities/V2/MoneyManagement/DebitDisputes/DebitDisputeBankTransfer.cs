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
        /// One of: <c>ach</c>, or <c>bacs</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// The reason for the dispute.
        /// One of: <c>beneficiary_unrecognized</c>, <c>incorrect_amount_or_date</c>,
        /// <c>mandate_canceled</c>, <c>mandate_canceled_by_stripe</c>, <c>no_advance_notice</c>,
        /// <c>originator_requested</c>, <c>signature_invalid</c>, or <c>unauthorized</c>.
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
