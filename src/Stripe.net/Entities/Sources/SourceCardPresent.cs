// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceCardPresent : StripeEntity<SourceCardPresent>
    {
        [JsonProperty("application_cryptogram")]
        [STJS.JsonPropertyName("application_cryptogram")]
        public string ApplicationCryptogram { get; set; }

        [JsonProperty("application_preferred_name")]
        [STJS.JsonPropertyName("application_preferred_name")]
        public string ApplicationPreferredName { get; set; }

        [JsonProperty("authorization_code")]
        [STJS.JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("authorization_response_code")]
        [STJS.JsonPropertyName("authorization_response_code")]
        public string AuthorizationResponseCode { get; set; }

        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("cvm_type")]
        [STJS.JsonPropertyName("cvm_type")]
        public string CvmType { get; set; }

        [JsonProperty("data_type")]
        [STJS.JsonPropertyName("data_type")]
        public string DataType { get; set; }

        [JsonProperty("dedicated_file_name")]
        [STJS.JsonPropertyName("dedicated_file_name")]
        public string DedicatedFileName { get; set; }

        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("emv_auth_data")]
        [STJS.JsonPropertyName("emv_auth_data")]
        public string EmvAuthData { get; set; }

        [JsonProperty("evidence_customer_signature")]
        [STJS.JsonPropertyName("evidence_customer_signature")]
        public string EvidenceCustomerSignature { get; set; }

        [JsonProperty("evidence_transaction_certificate")]
        [STJS.JsonPropertyName("evidence_transaction_certificate")]
        public string EvidenceTransactionCertificate { get; set; }

        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        [STJS.JsonPropertyName("funding")]
        public string Funding { get; set; }

        [JsonProperty("iin")]
        [STJS.JsonPropertyName("iin")]
        public string Iin { get; set; }

        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonProperty("pos_device_id")]
        [STJS.JsonPropertyName("pos_device_id")]
        public string PosDeviceId { get; set; }

        [JsonProperty("pos_entry_mode")]
        [STJS.JsonPropertyName("pos_entry_mode")]
        public string PosEntryMode { get; set; }

        [JsonProperty("read_method")]
        [STJS.JsonPropertyName("read_method")]
        public string ReadMethod { get; set; }

        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        [JsonProperty("terminal_verification_results")]
        [STJS.JsonPropertyName("terminal_verification_results")]
        public string TerminalVerificationResults { get; set; }

        [JsonProperty("transaction_status_information")]
        [STJS.JsonPropertyName("transaction_status_information")]
        public string TransactionStatusInformation { get; set; }
    }
}
