namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    // TODO (MAJOR): Accept a TOptions generic and use it to define method overloads
    // that allow passing in options.
    public interface ISingletonRetrievable<TEntity>
        where TEntity : IStripeEntity
    {
        TEntity Get(RequestOptions requestOptions = null);

        Task<TEntity> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
