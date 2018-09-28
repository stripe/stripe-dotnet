namespace Stripe
{
    using Stripe.Infrastructure;

    public class SourceReceiverOptions : INestedOptions
    {
        [FormProperty("refund_attributes_method")]
        public string RefundAttributesMethod { get; set; }
    }
}
