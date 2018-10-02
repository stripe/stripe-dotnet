namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargeUpdateOptions : BaseOptions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("fraud_details")]
        public Dictionary<string, string> FraudDetails { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods. For more information, see the Charge object documentation.
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
