// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargeCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount intended to be collected by this payment. A positive integer representing how
        /// much to charge in the <a href="https://docs.stripe.com/currencies#zero-decimal">smallest
        /// currency unit</a> (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a zero-decimal
        /// currency). The minimum amount is $0.50 US or <a
        /// href="https://docs.stripe.com/currencies#minimum-and-maximum-charge-amounts">equivalent
        /// in charge currency</a>. The amount value supports up to eight digits (e.g., a value of
        /// 99999999 for a USD charge of $999,999.99).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// A fee in cents (or local equivalent) that will be applied to the charge and transferred
        /// to the application owner's Stripe account. The request must be made with an OAuth key or
        /// the <c>Stripe-Account</c> header in order to take an application fee. For more
        /// information, see the application fees <a
        /// href="https://docs.stripe.com/connect/direct-charges#collect-fees">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Whether to immediately capture the charge. Defaults to <c>true</c>. When <c>false</c>,
        /// the charge issues an authorization (or pre-authorization), and will need to be <a
        /// href="https://api.stripe.com#capture_charge">captured</a> later. Uncaptured charges
        /// expire after a set number of days (7 by default). For more information, see the <a
        /// href="https://docs.stripe.com/charges/placing-a-hold">authorizing charges and settling
        /// later</a> documentation.
        /// </summary>
        [JsonProperty("capture")]
        [STJS.JsonPropertyName("capture")]
        public bool? Capture { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer that will be charged in this request.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a <c>Charge</c> object. It is displayed when
        /// in the web interface alongside the charge. Note that if you use Stripe to send automatic
        /// email receipts to your customers, your receipt emails will include the
        /// <c>description</c> of the charge(s) that they are describing.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public ChargeDestinationOptions Destination { get; set; }

        [JsonProperty("exchange_rate")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("level3")]
        [STJS.JsonPropertyName("level3")]
        public ChargeLevel3Options Level3 { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The Stripe account ID for which these funds are intended. You can specify the business
        /// of record as the connected account using the <c>on_behalf_of</c> attribute on the
        /// charge. For details, see <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#settlement-merchant">Creating
        /// Separate Charges and Transfers</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        [STJS.JsonPropertyName("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://docs.stripe.com/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
        [STJS.JsonPropertyName("radar_options")]
        public ChargeRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// The email address to which this charge's <a
        /// href="https://docs.stripe.com/dashboard/receipts">receipt</a> will be sent. The receipt
        /// will not be sent until the charge is paid, and no receipts will be sent for test mode
        /// charges. If this charge is for a <a
        /// href="https://docs.stripe.com/api/customers/object">Customer</a>, the email address
        /// specified here will override the customer's email address. If <c>receipt_email</c> is
        /// specified for a charge in live mode, a receipt will be sent regardless of your <a
        /// href="https://dashboard.stripe.com/account/emails">email settings</a>.
        /// </summary>
        [JsonProperty("receipt_email")]
        [STJS.JsonPropertyName("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// A payment source to be charged. This can be the ID of a <a
        /// href="https://docs.stripe.com/api#cards">card</a> (i.e., credit or debit card), a <a
        /// href="https://docs.stripe.com/api#bank_accounts">bank account</a>, a <a
        /// href="https://docs.stripe.com/api#sources">source</a>, a <a
        /// href="https://docs.stripe.com/api#tokens">token</a>, or a <a
        /// href="https://docs.stripe.com/connect/account-debits#charging-a-connected-account">connected
        /// account</a>. For certain sources---namely, <a
        /// href="https://docs.stripe.com/api#cards">cards</a>, <a
        /// href="https://docs.stripe.com/api#bank_accounts">bank accounts</a>, and attached <a
        /// href="https://docs.stripe.com/api#sources">sources</a>---you must also pass the ID of
        /// the associated customer.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
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
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement. If the account has no prefix value, the suffix is concatenated to
        /// the account's statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://docs.stripe.com/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. For details, see <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options">Grouping
        /// transactions</a>.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
