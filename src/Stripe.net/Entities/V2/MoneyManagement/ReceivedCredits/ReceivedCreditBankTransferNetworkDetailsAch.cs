// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditBankTransferNetworkDetailsAch : StripeEntity<ReceivedCreditBankTransferNetworkDetailsAch>
    {
        /// <summary>
        /// Payment-related information from the ACH addenda record, up to 80 characters.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }

        /// <summary>
        /// Company Entry Description from the ACH batch header, e.g. "HCCLAIMPMT".
        /// </summary>
        [JsonProperty("originator_company_entry_description")]
        [STJS.JsonPropertyName("originator_company_entry_description")]
        public string OriginatorCompanyEntryDescription { get; set; }

        /// <summary>
        /// Company Identification from the ACH batch header.
        /// </summary>
        [JsonProperty("originator_company_id")]
        [STJS.JsonPropertyName("originator_company_id")]
        public string OriginatorCompanyId { get; set; }

        /// <summary>
        /// Company Name from the ACH batch header -- the business that sent the funds.
        /// </summary>
        [JsonProperty("originator_company_name")]
        [STJS.JsonPropertyName("originator_company_name")]
        public string OriginatorCompanyName { get; set; }

        /// <summary>
        /// Identification Number from the ACH entry detail record.
        /// </summary>
        [JsonProperty("receiver_id_number")]
        [STJS.JsonPropertyName("receiver_id_number")]
        public string ReceiverIdNumber { get; set; }

        /// <summary>
        /// Individual Name from the ACH entry detail record.
        /// </summary>
        [JsonProperty("receiver_name")]
        [STJS.JsonPropertyName("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Open Enum. Standard Entry Class code of the ACH entry.
        /// One of: <c>ccd</c>, <c>cie</c>, <c>ctx</c>, <c>iat</c>, <c>pos</c>, <c>ppd</c>,
        /// <c>tel</c>, or <c>web</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("standard_entry_class_code")]
        [STJS.JsonPropertyName("standard_entry_class_code")]
        public string StandardEntryClassCode { get; set; }

        /// <summary>
        /// Trace Number from the ACH entry detail record.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
