using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeCaptureOptions
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to charge $1.00 or 100 to charge ¥100, a 0-decimal currency) representing how much to charge the card. The minimum amount is $0.50 US or equivalent in charge currency.
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
        
        /// <summary>
        /// The email address to send this charge's receipt to. The receipt will not be sent until the charge is paid. If this charge is for a customer, the email address specified here will override the customer's email address. Receipts will not be sent for test mode charges. If receipt_email is specified for a charge in live mode, a receipt will be sent regardless of your email settings.
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
