namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PaymentIntentSharedOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        [FormProperty("application_fee_amount")]
        public int? ApplicationFeeAmount { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("customer")]
        public string CustomerId { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [FormProperty("return_url")]
        public string ReturnUrl { get; set; }

        [FormProperty("save_source_to_customer")]
        public bool? SaveSourceToCustomer { get; set; }

        [FormProperty("source")]
        public string SourceId { get; set; }

        [FormProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        [FormProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
