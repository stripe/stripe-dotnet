namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount intended to be collected by this payment. A positive integer representing how
        /// much to charge in the <a href="https://stripe.com/docs/currencies#zero-decimal">smallest
        /// currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal
        /// currency). The minimum amount is $0.50 US or <a
        /// href="https://stripe.com/docs/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// A fee in %s that will be applied to the charge and transferred to the application
        /// owner's Stripe account. The request must be made with an OAuth key or the
        /// <c>Stripe-Account</c> header in order to take an application fee. For more information,
        /// see the application fees <a
        /// href="https://stripe.com/docs/connect/direct-charges#collecting-fees">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Whether to immediately capture the charge. Defaults to <c>true</c>. When <c>false</c>,
        /// the charge issues an authorization (or pre-authorization), and will need to be <a
        /// href="https://stripe.com/docs/api#capture_charge">captured</a> later. Uncaptured charges
        /// expire in <em>seven days</em>. For more information, see the <a
        /// href="https://stripe.com/docs/charges/placing-a-hold">authorizing charges and settling
        /// later</a> documentation.
        /// </summary>
        [JsonProperty("capture")]
        public bool? Capture { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer that will be charged in this request.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a <c>Charge</c> object. It is displayed when
        /// in the web interface alongside the charge. Note that if you use Stripe to send automatic
        /// email receipts to your customers, your receipt emails will include the
        /// <c>description</c> of the charge(s) that they are describing.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("destination")]
        public ChargeDestinationOptions Destination { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("level3")]
        public ChargeLevel3Options Level3 { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID for which these funds are intended. Automatically set if you use
        /// the <c>destination</c> parameter. For details, see <a
        /// href="https://stripe.com/docs/connect/charges-transfers#on-behalf-of">Creating Separate
        /// Charges and Transfers</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// The email address to which this charge's <a
        /// href="https://stripe.com/docs/dashboard/receipts">receipt</a> will be sent. The receipt
        /// will not be sent until the charge is paid, and no receipts will be sent for test mode
        /// charges. If this charge is for a <a
        /// href="https://stripe.com/docs/api/customers/object">Customer</a>, the email address
        /// specified here will override the customer's email address. If <c>receipt_email</c> is
        /// specified for a charge in live mode, a receipt will be sent regardless of your <a
        /// href="https://dashboard.stripe.com/account/emails">email settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// For card charges, use <c>statement_descriptor_suffix</c> instead. Otherwise, you can use
        /// this value as the complete description of a charge on your customers’ statements. Must
        /// contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about the charge that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://stripe.com/docs/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. For details, see <a
        /// href="https://stripe.com/docs/connect/charges-transfers#transfer-options">Grouping
        /// transactions</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
