namespace Stripe
{
    public interface IStripeEntityWithId : IStripeEntity
    {
        string Id { get; set; }
    }
}
