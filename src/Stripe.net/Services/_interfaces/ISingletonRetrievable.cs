namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ISingletonRetrievable<TEntity>
        where TEntity : IStripeEntity
    {
        TEntity Get(RequestOptions requestOptions = null);

        Task<TEntity> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
