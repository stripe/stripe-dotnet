namespace Stripe
{
    /// <summary>
    /// Resources that implement this interface can appear as sources in balance transactions.
    /// </summary>
    public interface IBalanceTransactionSource : IStripeEntity, IHasId, IHasObject
    {
    }
}
