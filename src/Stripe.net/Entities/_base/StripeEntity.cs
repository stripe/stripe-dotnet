namespace Stripe
{
    public abstract class StripeEntity : IStripeEntity
    {
        public StripeResponse StripeResponse { get; set; }
    }
}
