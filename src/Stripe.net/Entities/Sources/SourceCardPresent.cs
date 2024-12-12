// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceCardPresent : StripeEntity<SourceCardPresent>
    {
        [JsonProperty("application_cryptogram")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_cryptogram")]
#endif
        public string ApplicationCryptogram { get; set; }

        [JsonProperty("application_preferred_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_preferred_name")]
#endif
        public string ApplicationPreferredName { get; set; }

        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif
        public string AuthorizationCode { get; set; }

        [JsonProperty("authorization_response_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_response_code")]
#endif
        public string AuthorizationResponseCode { get; set; }

        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        [JsonProperty("cvm_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvm_type")]
#endif
        public string CvmType { get; set; }

        [JsonProperty("data_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data_type")]
#endif
        public string DataType { get; set; }

        [JsonProperty("dedicated_file_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dedicated_file_name")]
#endif
        public string DedicatedFileName { get; set; }

        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        [JsonProperty("emv_auth_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("emv_auth_data")]
#endif
        public string EmvAuthData { get; set; }

        [JsonProperty("evidence_customer_signature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evidence_customer_signature")]
#endif
        public string EvidenceCustomerSignature { get; set; }

        [JsonProperty("evidence_transaction_certificate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evidence_transaction_certificate")]
#endif
        public string EvidenceTransactionCertificate { get; set; }

        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif
        public long? ExpYear { get; set; }

        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public string Funding { get; set; }

        [JsonProperty("iin")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iin")]
#endif
        public string Iin { get; set; }

        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public string Issuer { get; set; }

        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        [JsonProperty("pos_device_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pos_device_id")]
#endif
        public string PosDeviceId { get; set; }

        [JsonProperty("pos_entry_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pos_entry_mode")]
#endif
        public string PosEntryMode { get; set; }

        [JsonProperty("read_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("read_method")]
#endif
        public string ReadMethod { get; set; }

        [JsonProperty("reader")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reader")]
#endif
        public string Reader { get; set; }

        [JsonProperty("terminal_verification_results")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terminal_verification_results")]
#endif
        public string TerminalVerificationResults { get; set; }

        [JsonProperty("transaction_status_information")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_status_information")]
#endif
        public string TransactionStatusInformation { get; set; }
    }
}
