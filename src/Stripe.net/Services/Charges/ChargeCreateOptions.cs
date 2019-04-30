namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeCreateOptions : BaseOptions
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a 0-decimal currency) representing how much to charge the card. The minimum amount is $0.50 US or equivalent in charge currency.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 3-letter ISO code for currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Obsolete("Use ApplicationFeeAmount")]
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// A fee in cents that will be applied to the charge and transferred to the application owner's Stripe account. To use an application fee, the request must be made on behalf of another account (using RequestOptions available on all service methods), using the Stripe-Account header, an OAuth key, or the destination parameter. For more information, see the application fees documentation.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Whether or not to immediately capture the charge. When false, the charge issues an authorization (or pre-authorization), and will need to be captured later. Uncaptured charges expire in 7 days. For more information, see authorizing charges and settling later.
        /// </summary>
        [JsonProperty("capture")]
        public bool? Capture { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a charge object. It is displayed when in the web interface alongside the charge. Note that if you use Stripe to send automatic email receipts to your customers, your receipt emails will include the description of the charge(s) that they are describing.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// If specified, the charge will be attributed to the destination account for tax reporting, and the funds from the charge will be transferred to the destination account.
        /// </summary>
        [JsonProperty("destination")]
        public ChargeDestinationCreateOptions Destination { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Extra information about the charge passing level III data to card networks
        /// </summary>
        [JsonProperty("level3")]
        public ChargeLevel3Options Level3 { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. For details, see
        /// <see href="https://stripe.com/docs/connect/charges-transfers#grouping-transactions">Grouping transactions</see>.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }

        /// <summary>
        /// The Stripe account ID that these funds are intended for. Automatically set if you use the destination parameter. See the Connect documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for storing additional information about the customer in a structured format. It's often a good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The email address to send this charge's receipt to. The receipt will not be sent until the charge is paid. If this charge is for a customer, the email address specified here will override the customer's email address. Receipts will not be sent for test mode charges. If receipt_email is specified for a charge in live mode, a receipt will be sent regardless of your email settings.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods. For more information, see the Charge object documentation.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// The ID of an existing customer that will be charged in this request.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A payment source to be charged. This can be the ID of a card (i.e., credit or debit
        /// card), a bank account, a source, a token, or a connected account. For certain
        /// sources—namely, cards, bank accounts, and attached sources—you must also pass the ID of
        /// the associated customer.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

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

        [JsonProperty("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }
    }
}
