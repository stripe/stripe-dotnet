namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface INestedRetrievable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : BaseOptions
    {
        TEntity Get(string parentId, string id, TOptions retrieveOptions, RequestOptions requestOptions = null);

        Task<TEntity> GetAsync(string parentId, string id, TOptions retrieveOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
