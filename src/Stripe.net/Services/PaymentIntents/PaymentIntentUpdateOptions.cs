namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("payment_method_data")]
        public PaymentIntentPaymentMethodDataOptions PaymentMethodData { get; set; }

        [JsonProperty("payment_method_options")]
        public PaymentIntentPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
