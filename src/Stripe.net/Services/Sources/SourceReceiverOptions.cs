namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceReceiverOptions : INestedOptions
    {
        [JsonProperty("refund_attributes_method")]
        public string RefundAttributesMethod { get; set; }
    }
}
