namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsInteracPresentReceipt : StripeEntity<ChargePaymentMethodDetailsInteracPresentReceipt>
    {
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("application_cryptogram")]
        public string ApplicationCryptogram { get; set; }

        [JsonProperty("application_preferred_name")]
        public string ApplicationPreferredName { get; set; }

        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("authorization_response_code")]
        public string AuthorizationResponseCode { get; set; }

        [JsonProperty("cardholder_verification_method")]
        public string CardholderVerificationMethod { get; set; }

        [JsonProperty("dedicated_file_name")]
        public string DedicatedFileName { get; set; }

        [JsonProperty("terminal_verification_results")]
        public string TerminalVerificationResults { get; set; }

        [JsonProperty("transaction_status_information")]
        public string TransactionStatusInformation { get; set; }
    }
}
