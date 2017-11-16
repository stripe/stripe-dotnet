using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeCaptureOptions : StripeBaseOptions
    {
        /// <summary>
        /// Amount to capture on the authorization
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// A fee in cents that will be applied to the charge and transferred to the application owner's Stripe account. To use an application fee, the request must be made on behalf of another account (using StripeRequestOptions available on all service methods), using the Stripe-Account header, an OAuth key, or the destination parameter. For more information, see the application fees documentation.
        /// </summary>
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// ID of an existing, connected stripe account.
        /// </summary>
        [JsonProperty("destination[account]")]
        public string Destination { get; set; }

        /// <summary>
        /// The amount to transfer to the destination account without creating an Application Fee. Cannot be combined with the <see cref="ApplicationFee" /> parameter. Must be equal to or lesser than the charge amount.
        /// </summary>
        [JsonProperty("destination[amount]")]
        public int? DestinationAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Email address that will receive an email receipt confirming the transaction.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card statement. This may be up to 22 characters. As an example, if your website is RunClub and the item you're charging for is a race ticket, you may want to specify a statement_descriptor of RunClub 5K race ticket. The statement description may not include <>"' characters, and will appear on your customer's statement in capital letters. Non-ASCII characters are automatically stripped. While most banks display this information consistently, some may display it incorrectly or not at all.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
