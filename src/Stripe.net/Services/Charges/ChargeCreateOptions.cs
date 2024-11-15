// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

        /// <summary>
        /// A fee in cents (or local equivalent) that will be applied to the charge and transferred
        /// to the application owner's Stripe account. The request must be made with an OAuth key or
        /// the <c>Stripe-Account</c> header in order to take an application fee. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/direct-charges#collect-fees">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif

        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Whether to immediately capture the charge. Defaults to <c>true</c>. When <c>false</c>,
        /// the charge issues an authorization (or pre-authorization), and will need to be <a
        /// href="https://stripe.com/docs/api#capture_charge">captured</a> later. Uncaptured charges
        /// expire after a set number of days (7 by default). For more information, see the <a
        /// href="https://stripe.com/docs/charges/placing-a-hold">authorizing charges and settling
        /// later</a> documentation.
        /// </summary>
        [JsonProperty("capture")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capture")]
#endif

        public bool? Capture { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer that will be charged in this request.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a <c>Charge</c> object. It is displayed when
        /// in the web interface alongside the charge. Note that if you use Stripe to send automatic
        /// email receipts to your customers, your receipt emails will include the
        /// <c>description</c> of the charge(s) that they are describing.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif

        public ChargeDestinationOptions Destination { get; set; }

        [JsonProperty("exchange_rate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exchange_rate")]
#endif

        public decimal? ExchangeRate { get; set; }

        [JsonProperty("level3")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("level3")]
#endif

        public ChargeLevel3Options Level3 { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID for which these funds are intended. Automatically set if you use
        /// the <c>destination</c> parameter. For details, see <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers#settlement-merchant">Creating
        /// Separate Charges and Transfers</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif

        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("radar_options")]
#endif

        public ChargeRadarOptionsOptions RadarOptions { get; set; }

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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_email")]
#endif

        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif

        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// A payment source to be charged. This can be the ID of a <a
        /// href="https://stripe.com/docs/api#cards">card</a> (i.e., credit or debit card), a <a
        /// href="https://stripe.com/docs/api#bank_accounts">bank account</a>, a <a
        /// href="https://stripe.com/docs/api#sources">source</a>, a <a
        /// href="https://stripe.com/docs/api#tokens">token</a>, or a <a
        /// href="https://stripe.com/docs/connect/account-debits#charging-a-connected-account">connected
        /// account</a>. For certain sources---namely, <a
        /// href="https://stripe.com/docs/api#cards">cards</a>, <a
        /// href="https://stripe.com/docs/api#bank_accounts">bank accounts</a>, and attached <a
        /// href="https://stripe.com/docs/api#sources">sources</a>---you must also pass the ID of
        /// the associated customer.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// For a non-card charge, text that appears on the customer's statement as the statement
        /// descriptor. This value overrides the account's default statement descriptor. For
        /// information about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// For a card charge, this value is ignored unless you don't specify a
        /// <c>statement_descriptor_suffix</c>, in which case this value is used as the suffix.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement. If the account has no prefix value, the suffix is concatenated to
        /// the account's statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
#endif

        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://stripe.com/docs/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif

        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. For details, see <a
        /// href="https://stripe.com/docs/connect/separate-charges-and-transfers#transfer-options">Grouping
        /// transactions</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif

        public string TransferGroup { get; set; }
    }
}
