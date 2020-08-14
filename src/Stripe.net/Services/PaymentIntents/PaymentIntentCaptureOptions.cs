namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentCaptureOptions : BaseOptions
    {
        [JsonProperty("amount_to_capture")]
        public long? AmountToCapture { get; set; }

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}
