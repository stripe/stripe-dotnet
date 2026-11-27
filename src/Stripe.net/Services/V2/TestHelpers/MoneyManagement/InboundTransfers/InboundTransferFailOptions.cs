// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferFailOptions : BaseOptions
    {
        /// <summary>
        /// The failure reason to attach to the failed InboundTransfer.
        /// One of: <c>bank_account_closed</c>, <c>bank_account_not_found</c>,
        /// <c>bank_debit_could_not_be_processed</c>, <c>bank_debit_not_authorized</c>, or
        /// <c>insufficient_funds</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }
    }
}
