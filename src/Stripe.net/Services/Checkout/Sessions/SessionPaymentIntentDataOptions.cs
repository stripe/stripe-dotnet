namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionPaymentIntentDataOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        [JsonProperty("transfer_data")]
        public SessionPaymentIntentTransferDataOptions TransferData { get; set; }
    }
}
