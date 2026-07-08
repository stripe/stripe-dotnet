// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionNetworkData : StripeEntity<TransactionNetworkData>
    {
        /// <summary>
        /// The network-provided acquirer reference number for this transaction, if available. Use
        /// this value for downstream operational workflows such as filing disputes with the card
        /// network.
        /// </summary>
        [JsonProperty("acquirer_reference_number")]
        [STJS.JsonPropertyName("acquirer_reference_number")]
        public string AcquirerReferenceNumber { get; set; }

        /// <summary>
        /// The two-letter country code of the acquirer (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("acquiring_institution_country")]
        [STJS.JsonPropertyName("acquiring_institution_country")]
        public string AcquiringInstitutionCountry { get; set; }

        /// <summary>
        /// Identifier assigned to the acquirer by the card network. Sometimes this value is not
        /// provided by the network; in this case, the value will be null.
        /// </summary>
        [JsonProperty("acquiring_institution_id")]
        [STJS.JsonPropertyName("acquiring_institution_id")]
        public string AcquiringInstitutionId { get; set; }

        /// <summary>
        /// A code created by Stripe which is shared with the merchant to validate the
        /// authorization. This field will be populated if the authorization message was approved.
        /// The code typically starts with the letter "S", followed by a six-digit number. For
        /// example, "S498162". Please note that the code is not guaranteed to be unique across
        /// authorizations.
        /// </summary>
        [JsonProperty("authorization_code")]
        [STJS.JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// The date the transaction was processed by the card network. This can be different from
        /// the date the seller recorded the transaction depending on when the acquirer submits the
        /// transaction to the network.
        /// </summary>
        [JsonProperty("processing_date")]
        [STJS.JsonPropertyName("processing_date")]
        public string ProcessingDate { get; set; }

        /// <summary>
        /// Identifier assigned by the acquirer to track all messages related to this transaction.
        /// </summary>
        [JsonProperty("retrieval_reference_number")]
        [STJS.JsonPropertyName("retrieval_reference_number")]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// The card network over which Stripe received the transaction. This field may differ from
        /// the associated card’s primary network.
        /// One of: <c>cirrus</c>, <c>interlink</c>, <c>maestro</c>, <c>mastercard</c>,
        /// <c>other</c>, <c>plus</c>, or <c>visa</c>.
        /// </summary>
        [JsonProperty("routed_network")]
        [STJS.JsonPropertyName("routed_network")]
        public string RoutedNetwork { get; set; }

        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public TransactionNetworkDataTraceId TraceId { get; set; }

        /// <summary>
        /// Unique identifier for the authorization assigned by the card network used to match
        /// subsequent messages, disputes, and transactions.
        /// </summary>
        [JsonProperty("transaction_id")]
        [STJS.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
