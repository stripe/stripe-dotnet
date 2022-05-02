namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedSingletonRetrievable<TEntity, TOptions>
        where TEntity : IStripeEntity
        where TOptions : BaseOptions, new()
    {
        TEntity Get(string parentId, TOptions retrieveOptions = null, RequestOptions requestOptions = null);

        Task<TEntity> GetAsync(string parentId, TOptions retrieveOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
