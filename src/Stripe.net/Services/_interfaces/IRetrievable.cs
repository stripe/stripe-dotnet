namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRetrievable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : BaseOptions
    {
        TEntity Get(string id, TOptions retrieveOptions, RequestOptions requestOptions = null);

        Task<TEntity> GetAsync(string id, TOptions retrieveOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
