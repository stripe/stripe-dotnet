namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeCaptureOptions : BaseOptions
    {
        /// <summary>
        /// Amount to capture on the authorization.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// This is deprecated in favor of ApplicationFeeAmount.
        /// </summary>
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// A fee in cents that will be applied to the charge and transferred to the application owner's Stripe account. To use an application fee, the request must be made on behalf of another account (using RequestOptions available on all service methods), using the Stripe-Account header, an OAuth key, or the destination parameter. For more information, see the application fees documentation.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Email address that will receive an email receipt confirming the transaction.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card statement. This may
        /// be up to 22 characters. As an example, if your website is <c>RunClub</c> and the item
        /// you're charging for is a race ticket, you may want to specify a
        /// <c>statement_descriptor</c> of <c>RunClub 5K race ticket</c>. The statement description
        /// may not include <c>&lt;&gt;"'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped. While
        /// most banks display this information consistently, some may display it incorrectly or not
        /// at all.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that's set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge.
        /// </summary>
        [JsonProperty("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. <c>TransferGroup</c> may
        /// only be provided if it has not been set. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
