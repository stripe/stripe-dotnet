using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderPayOptions : StripeBaseOptions, ISupportMetadata
    {
        /// <summary>
        /// The ID of an existing customer that will be charged in this request.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A payment source to be charged, such as a credit card. If you also pass a customer ID, the source must be the ID of a source belonging to the customer. Otherwise, if you do not pass a customer ID, the source you provide must either be a token, like the ones returned by Stripe.js.
        /// </summary>
        [JsonProperty("source")]
        public string SourceId { get; set; }
        // todo: this has extra properties for later

        /// <summary>
        /// A fee in cents that will be applied to the order and transferred to the application owner's Stripe account. To use an application fee, the request must be made on behalf of another account, using the Stripe-Account header or OAuth key. For more information, see the application fees documentation.
        /// </summary>
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// The email address of the customer placing the order. If a customer is specified, that customer's email address will be used.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to an order object. It can be useful for storing additional information about the order in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
