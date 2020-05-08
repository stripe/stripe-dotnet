namespace Stripe
{
    public interface IExternalAccount : IStripeEntity, IHasId, IHasObject
    {
        Account Account { get; }

        string AccountId { get; }
    }
}
