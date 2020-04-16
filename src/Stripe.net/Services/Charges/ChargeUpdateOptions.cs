namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargeUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The ID of an existing customer that will be associated with this charge. This field may
        /// only be updated if there is no existing associated customer with this charge.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to a charge object. It is displayed when in the
        /// web interface alongside the charge. Note that if you use Stripe to send automatic email
        /// receipts to your customers, your receipt emails will include the description of the
        /// charge(s) that they are describing.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Stripe will use the information you send to improve our fraud detection algorithms.
        /// </summary>
        [JsonProperty("fraud_details")]
        public ChargeFraudDetailsOptions FraudDetails { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A This is the email address that the receipt for this charge will be sent to. If this
        /// field is updated, then a new email receipt will be sent to the updated address.
        /// </summary>
        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods.
        /// For more information, see the Charge object documentation.
        /// </summary>
        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. <c>transfer_group</c> may
        /// only be provided if it has not been set. See the
        /// <see href="https://stripe.com/docs/connect/charges-transfers#grouping-transactions">Connect documentation</see>
        /// for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
