namespace Stripe
{
    /// <summary>
    /// Resources that implement this interface can be used to create charges.
    /// </summary>
    public interface IPaymentSource : IStripeEntity, IHasId, IHasObject
    {
    }
}
