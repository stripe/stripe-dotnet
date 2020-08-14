namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class TransactionPurchaseDetails : StripeEntity<TransactionPurchaseDetails>
    {
        [JsonProperty("flight")]
        public TransactionPurchaseDetailsFlight Flight { get; set; }

        [JsonProperty("fuel")]
        public TransactionPurchaseDetailsFuel Fuel { get; set; }

        [JsonProperty("lodging")]
        public TransactionPurchaseDetailsLodging Lodging { get; set; }

        [JsonProperty("receipt")]
        public List<TransactionPurchaseDetailsReceipt> Receipt { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
