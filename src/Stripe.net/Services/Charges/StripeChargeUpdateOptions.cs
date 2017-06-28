using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeUpdateOptions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

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
        public StripeShippingOptions Shipping { get; set; }
    }
}
