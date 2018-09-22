namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentSharedOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("application_fee_amount")]
        public int? ApplicationFeeAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        [JsonProperty("save_source_to_customer")]
        public bool? SaveSourceToCustomer { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
