namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeCaptureOptions : BaseOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        [JsonProperty("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
