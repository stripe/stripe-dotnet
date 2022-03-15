namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ISearchable<TEntity, TOptions>
        where TEntity : IStripeEntity, IHasId
        where TOptions : SearchOptions, new()
    {
        StripeSearchResult<TEntity> Search(TOptions searchOptions = null, RequestOptions requestOptions = null);

        Task<StripeSearchResult<TEntity>> SearchAsync(TOptions searchOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);

        IEnumerable<TEntity> SearchAutoPaging(TOptions searchOptions = null, RequestOptions requestOptions = null);

        IAsyncEnumerable<TEntity> SearchAutoPagingAsync(TOptions searchOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}
