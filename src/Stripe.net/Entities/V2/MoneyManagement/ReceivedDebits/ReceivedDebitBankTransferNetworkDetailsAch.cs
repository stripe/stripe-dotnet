// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitBankTransferNetworkDetailsAch : StripeEntity<ReceivedDebitBankTransferNetworkDetailsAch>
    {
        /// <summary>
        /// Additional information included with the ACH debit.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }

        /// <summary>
        /// The entry description supplied by the company that originated the ACH debit.
        /// </summary>
        [JsonProperty("originator_company_entry_description")]
        [STJS.JsonPropertyName("originator_company_entry_description")]
        public string OriginatorCompanyEntryDescription { get; set; }

        /// <summary>
        /// The identifier of the company that originated the ACH debit.
        /// </summary>
        [JsonProperty("originator_company_id")]
        [STJS.JsonPropertyName("originator_company_id")]
        public string OriginatorCompanyId { get; set; }

        /// <summary>
        /// The name of the company that originated the ACH debit.
        /// </summary>
        [JsonProperty("originator_company_name")]
        [STJS.JsonPropertyName("originator_company_name")]
        public string OriginatorCompanyName { get; set; }

        /// <summary>
        /// The identifier assigned to the receiver of the ACH debit.
        /// </summary>
        [JsonProperty("receiver_id_number")]
        [STJS.JsonPropertyName("receiver_id_number")]
        public string ReceiverIdNumber { get; set; }

        /// <summary>
        /// The name of the receiver of the ACH debit.
        /// </summary>
        [JsonProperty("receiver_name")]
        [STJS.JsonPropertyName("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Open Enum. The standard entry class code for the ACH debit.
        /// One of: <c>ccd</c>, <c>cie</c>, <c>ctx</c>, <c>iat</c>, <c>pos</c>, <c>ppd</c>,
        /// <c>tel</c>, or <c>web</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("standard_entry_class_code")]
        [STJS.JsonPropertyName("standard_entry_class_code")]
        public string StandardEntryClassCode { get; set; }

        /// <summary>
        /// The trace identifier for the ACH debit.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
