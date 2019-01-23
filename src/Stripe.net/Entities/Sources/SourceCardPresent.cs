namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceCardPresent : StripeEntity<SourceCardPresent>
    {
        [JsonProperty("application_cryptogram")]
        public string ApplicationCryptogram { get; set; }

        [JsonProperty("application_preferred_name")]
        public string ApplicationPreferredName { get; set; }

        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("authorization_response_code")]
        public string AuthorizationResponseCode { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("cvm_type")]
        public string CvmType { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("dedicated_file_name")]
        public string DedicatedFileName { get; set; }

        [JsonProperty("emv_auth_data")]
        public string EmvAuthData { get; set; }

        [JsonProperty("evidence_customer_signature")]
        public string EvidenceCustomerSignature { get; set; }

        [JsonProperty("evidence_transaction_certificate")]
        public string EvidenceTransactionCertificate { get; set; }

        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("funding")]
        public string Funding { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("pos_device_id")]
        public string PosDeviceId { get; set; }

        [JsonProperty("pos_entry_mode")]
        public string PosEntryMode { get; set; }

        [JsonProperty("read_method")]
        public string ReadMethod { get; set; }

        [JsonProperty("reader")]
        public string Reader { get; set; }

        [JsonProperty("terminal_verification_results")]
        public string TerminalVerificationResults { get; set; }

        [JsonProperty("transaction_status_information")]
        public string TransactionStatusInformation { get; set; }
    }
}
