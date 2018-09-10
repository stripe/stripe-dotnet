namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeSourceReceiverOptions : INestedOptions
    {
        [JsonProperty("refund_attributes_method")]
        public string RefundAttributesMethod { get; set; }
    }
}
