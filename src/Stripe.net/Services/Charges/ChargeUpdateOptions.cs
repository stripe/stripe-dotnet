namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargeUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [JsonProperty("fraud_details")]
        public ChargeFraudDetailsOptions FraudDetails { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
