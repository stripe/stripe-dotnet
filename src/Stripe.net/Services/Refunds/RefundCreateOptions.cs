namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RefundCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}
