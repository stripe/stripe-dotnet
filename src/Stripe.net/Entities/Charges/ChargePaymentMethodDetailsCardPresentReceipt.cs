namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardPresentReceipt : StripeEntity<ChargePaymentMethodDetailsCardPresentReceipt>
    {
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
